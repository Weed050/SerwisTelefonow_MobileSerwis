using SerwisTelefonow.Data;
using SerwisTelefonow.DBModels;
using System.Data;
using System.Text;


namespace SerwisTelefonow.Models
{
    public partial class SearchServRecords : Form
    {
        private AppDbContext appDbContext;
        public SearchServRecords(AppDbContext _context)
        {
            InitializeComponent();
            appDbContext = _context;
            LoadServEntry();
            LoadClient();
            LoadPhoneModels();
            AdjustTablesWidth();
        }

        private void AdjustTablesWidth()
        {
            dataGridViewServRecords.AutoResizeColumns();
            dataGridViewClients.AutoResizeColumns();
            dataGridViewPhoneModel.AutoResizeColumns();

            int servRecordsOptimalWidth = GetOptimalTableWidth(dataGridViewServRecords);
            int clientsOptimalWidth = GetOptimalTableWidth(dataGridViewClients);
            int phoneModelOptimalWidth = GetOptimalTableWidth(dataGridViewPhoneModel);

            dataGridViewServRecords.Width = servRecordsOptimalWidth;
            dataGridViewClients.Width = clientsOptimalWidth;
            dataGridViewPhoneModel.Width = phoneModelOptimalWidth;


            dataGridViewClients.Left = (groupBox2.ClientSize.Width - clientsOptimalWidth) / 2;
            dataGridViewPhoneModel.Left = (groupBox3.ClientSize.Width - phoneModelOptimalWidth) / 2;

            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;

            int formWidth = this.ClientSize.Width;
            int width2 = groupBox2.Width;
            int width3 = groupBox3.Width;
            int gap = (formWidth - (width2 + width3)) / 3;


            groupBox3.Left = gap;
            groupBox2.Left = gap * 2 + width3;

            dataGridViewServRecords.Refresh();
            dataGridViewClients.Refresh();
            dataGridViewPhoneModel.Refresh();
        }

        private int GetOptimalTableWidth(DataGridView dataGridView)
        {
            int totalWidth = dataGridView.RowHeadersVisible ? dataGridView.RowHeadersWidth : 0;
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (!col.Visible) continue;
                totalWidth += col.Width;
            }
            totalWidth += 30;
            return totalWidth;
        }

        private void LoadServEntry()
        {
            var sourceServEntry = appDbContext.ServiceEntry.ToList();
            dataGridViewServRecords.DataSource = sourceServEntry;


            if (dataGridViewServRecords.Columns.Contains("Model"))
            {
                dataGridViewServRecords.Columns["Model"].Visible = false;
            }
            if (dataGridViewServRecords.Columns.Contains("Client"))
            {
                dataGridViewServRecords.Columns["Client"].Visible = false;
            }

            if (!dataGridViewServRecords.Columns.Contains("Klient"))
            {
                var comboColumn = new DataGridViewComboBoxColumn();
                comboColumn.Name = "Klient";
                comboColumn.DataPropertyName = "KlientId";
                comboColumn.HeaderText = "Klient";
                comboColumn.DataSource = appDbContext.Clients
                    .Select(c => new { c.Id, FullName = c.Imie + " " + c.Nazwisko })
                    .ToList();
                comboColumn.DisplayMember = "FullName";
                comboColumn.ValueMember = "Id";

                dataGridViewServRecords.Columns.Add(comboColumn);
            }
            else
            {
                var combo = dataGridViewServRecords.Columns["Klient"] as DataGridViewComboBoxColumn;
                if (combo != null)
                {
                    combo.DataSource = appDbContext.Clients
                        .Select(c => new { c.Id, FullName = c.Imie + " " + c.Nazwisko })
                        .ToList();
                }
            }

        }

        private void LoadClient()
        {
            var sourceClients = appDbContext.Clients.ToList();
            dataGridViewClients.DataSource = sourceClients;
            if (dataGridViewClients.Columns.Contains("WpisySerwisowe"))
            {
                dataGridViewClients.Columns["WpisySerwisowe"].Visible = false;
            }
        }

        private void LoadPhoneModels()
        {
            var sourcePhoneModels = appDbContext.PhoneModel.ToList();
            dataGridViewPhoneModel.DataSource = sourcePhoneModels;
            if (dataGridViewPhoneModel.Columns.Contains("WpisySerwisowe"))
            {
                dataGridViewPhoneModel.Columns["WpisySerwisowe"].Visible = false;
            }
        }

        private void buttonSaveServEntry_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewServRecords.Rows)
                {
                    if (row.IsNewRow) continue;

                    int recordId = Convert.ToInt32(row.Cells["Id"].Value);
                    var record = appDbContext.ServiceEntry.FirstOrDefault(x => x.Id == recordId);

                    if (record != null)
                    {
                        record.Opis = row.Cells["Opis"].Value.ToString();
                        record.CenaWstepna = Convert.ToDecimal(row.Cells["CenaWstepna"].Value);
                    }
                }

                appDbContext.SaveChanges();
                MessageBox.Show("Zmiany zostały zapisane!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisywania danych: {ex.Message}");
            }
        }

        private void buttonSaveClientData_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewClients.Rows)
                {
                    if (row.IsNewRow) continue;

                    int clientId = Convert.ToInt32(row.Cells["Id"].Value);
                    var client = appDbContext.Clients.FirstOrDefault(x => x.Id == clientId);

                    if (client != null)
                    {
                        client.Imie = row.Cells["Imie"].Value.ToString();
                        client.Nazwisko = row.Cells["Nazwisko"].Value.ToString();
                        client.Telefon = row.Cells["Telefon"].Value?.ToString();
                    }
                }

                appDbContext.SaveChanges();
                MessageBox.Show("Zmiany w danych klientów zostały zapisane!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisywania: {ex.Message}");
            }
            RefreshData();
        }

        private void buttonDeleteClientRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewClients.CurrentRow == null)
                {
                    MessageBox.Show("Wybierz klienta do usunięcia!");
                    return;
                }

                int clientId = Convert.ToInt32(dataGridViewClients.CurrentRow.Cells["Id"].Value);
                var client = appDbContext.Clients.FirstOrDefault(x => x.Id == clientId);

                if (client != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"Czy na pewno chcesz usunąć klienta {client.Imie} {client.Nazwisko}?",
                        "Potwierdzenie usunięcia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (result == DialogResult.Yes)
                    {
                        appDbContext.Clients.Remove(client);
                        appDbContext.SaveChanges();
                        LoadClient();
                        MessageBox.Show("Klient został usunięty!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas usuwania klienta: {ex.Message}");
            }
            RefreshData();
        }

        private void buttonDeleteServEntrRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewServRecords.CurrentRow == null)
                {
                    MessageBox.Show("Wybierz rekord do usunięcia!");
                    return;
                }

                int recordId = Convert.ToInt32(dataGridViewServRecords.CurrentRow.Cells["Id"].Value);
                var record = appDbContext.ServiceEntry.FirstOrDefault(x => x.Id == recordId);

                if (record != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"Czy na pewno chcesz usunąć rekord ID: {recordId}?",
                        "Potwierdzenie usunięcia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        appDbContext.ServiceEntry.Remove(record);
                        appDbContext.SaveChanges();
                        LoadServEntry();
                        MessageBox.Show("Rekord został usunięty!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas usuwania: {ex.Message}");
            }
            RefreshData();
        }

        private void buttonDeletePhoneModel_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridViewPhoneModel.CurrentRow == null)
                {
                    MessageBox.Show("Wybierz model do usunięcia!");
                    return;
                }

                string kodModelu = dataGridViewPhoneModel.CurrentRow.Cells["KodModelu"].Value?.ToString();
                var model = appDbContext.PhoneModel.FirstOrDefault(x => x.KodModelu == kodModelu);

                if (model != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"Czy na pewno chcesz usunąć model {model.Marka} {model.PelnaNazwa}?",
                        "Potwierdzenie usunięcia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        appDbContext.PhoneModel.Remove(model);
                        appDbContext.SaveChanges();
                        LoadPhoneModels();
                        MessageBox.Show("Model został usunięty!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas usuwania modelu: {ex.Message}");
            }
            RefreshData();
        }

        private void buttonSaveModel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewPhoneModel.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Kluczem w PhoneModel jest KodModelu – zakładamy, że każdy rekord ma unikalny kod
                    string kodModelu = row.Cells["KodModelu"].Value?.ToString();
                    var model = appDbContext.PhoneModel.FirstOrDefault(x => x.KodModelu == kodModelu);

                    if (model != null)
                    {
                        model.Marka = row.Cells["Marka"].Value?.ToString();
                        model.PelnaNazwa = row.Cells["PelnaNazwa"].Value?.ToString();
                    }
                }
                appDbContext.SaveChanges();
                MessageBox.Show("Zmiany w danych modeli zostały zapisane!");
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisywania modeli: {ex.Message}");
            }
        }
        private void RefreshData()
        {
            LoadServEntry();
            LoadClient();
            LoadPhoneModels();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        public static string GenerateServiceCode(int serviceEntryId, int clientId)
        {
            const int idFieldLength = 3;

            string servicePart = serviceEntryId.ToString("D" + idFieldLength);
            string clientPart = clientId.ToString("D" + idFieldLength);

            char RandomChar(Random rnd)
            {
                const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return pool[rnd.Next(pool.Length)];
            }

            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(12);
            for (int i = 0; i < 3; i++) { sb.Append(RandomChar(rnd)); }
            sb.Append(servicePart);
            for (int i = 0; i < 2; i++) { sb.Append(RandomChar(rnd)); }
            sb.Append(clientPart);
            sb.Append(RandomChar(rnd));

            return sb.ToString();
        }


        private void dataGridViewServRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pomijamy kliknięcia w nagłówki
            if (e.RowIndex < 0)
                return;

            // Pobieramy wiersz, z którego kliknięto pole
            DataGridViewRow row = dataGridViewServRecords.Rows[e.RowIndex];
            // Zakładamy, że DataGridView jest powiązany bezpośrednio z obiektami ServiceEntry
            ServiceEntry serviceEntry = row.DataBoundItem as ServiceEntry;
            if (serviceEntry != null)
            {
                // Generujemy kod z wykorzystaniem ID wpisu serwisowego oraz ID klienta
                string code = GenerateServiceCode(serviceEntry.Id, serviceEntry.KlientId);
                // Możesz wyświetlić kod w dedykowanej kontrolce, np. TextBoxServisCode
                textBoxServisCode.Text = code;
            }
        }
        public static bool TryParseServiceCode(string code, out int serviceEntryId, out int clientId)
        {
            serviceEntryId = 0;
            clientId = 0;

            if (string.IsNullOrEmpty(code) || code.Length != 12)
                return false;

            string servicePart = code.Substring(3, 3);
            string clientPart = code.Substring(8, 3);

            if (!int.TryParse(servicePart, out serviceEntryId))
                return false;
            if (!int.TryParse(clientPart, out clientId))
                return false;

            return true;
        }

        private void buttonSearchSerEntrByCode_Click(object sender, EventArgs e)
        {
            string code = textBoxServCodeIn.Text.Trim();

            // 1) Parsujemy kod
            if (!TryParseServiceCode(code, out int serviceEntryId, out int clientId))
            {
                MessageBox.Show("Niepoprawny kod serwisowy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Wyczyść zaznaczenie
            dataGridViewServRecords.ClearSelection();

            // 3) Przejdź przez wszystkie wiersze i znajdź to ID
            bool found = false;
            foreach (DataGridViewRow row in dataGridViewServRecords.Rows)
            {
                if (row.IsNewRow) continue;

                if ((int)row.Cells["Id"].Value == serviceEntryId)
                {
                    // 4a) Zaznacz wiersz
                    row.Selected = true;
                    // 4b) Przewiń do niego
                    dataGridViewServRecords.FirstDisplayedScrollingRowIndex = row.Index;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show($"Nie znaleziono wpisu o ID = {serviceEntryId}.", "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
