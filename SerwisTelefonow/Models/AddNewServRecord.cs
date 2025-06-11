using Microsoft.EntityFrameworkCore;
using SerwisTelefonow.Data;
using SerwisTelefonow.DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerwisTelefonow.Models
{
    public partial class AddNewServRecord : Form
    {
        private System.Windows.Forms.TextBox[] textBoxes;
        private readonly AppDbContext context;
        public AddNewServRecord(AppDbContext _context)
        {
            InitializeComponent();
            context = _context;
            textBoxes = new System.Windows.Forms.TextBox[] { textBoxImie, textBoxNazwisko, textBoxTelefon, textBoxModelCode, textBoxDesc, textBoxFirstPrice, textBoxImei };


            LoadClients();
            LoadModels();


            AlignBoxesInForm();
            AdjustModelsTableWidth();
            AdjustClientTableWidth();

            //foreach (var box in textBoxes)
            //    box.Text = String.Empty;
        }
        private void AlignBoxesInForm()
        {
            int totalWidth = this.ClientSize.Width;

            int box1Width = groupBox1.Width;
            int boxClientDataWidth = groupBoxClientData.Width;
            int box3Width = groupBox3.Width;

            int spacing = (totalWidth - (box1Width + boxClientDataWidth + box3Width)) / 4;

            groupBox1.Location = new Point(spacing + 50, groupBox1.Location.Y);
            groupBoxClientData.Location = new Point(groupBox3.Right + spacing, groupBoxClientData.Location.Y);
            groupBox3.Location = new Point(groupBox1.Right + spacing, groupBox3.Location.Y);
        }


        public void LoadArrayBox()
        {
            var source = context.PhoneModel
                .Select(x => new
                {
                    kod_modelu = x.KodModelu,
                    marka = x.Marka,
                    pelna_nazwa = x.PelnaNazwa,
                }).ToArray();

            dataGridViewModels.DataSource = source;
        }
        public void LoadClients(string filter = "")
        {
            IQueryable<Clients> query = context.Clients;

            if (!string.IsNullOrWhiteSpace(filter))
            {
                string lowerFilter = filter.ToLower();
                query = query.Where(x =>
                    x.Imie.ToLower().Contains(lowerFilter) ||
                    x.Nazwisko.ToLower().Contains(lowerFilter) ||
                    (x.Telefon != null && x.Telefon.ToLower().Contains(lowerFilter))
                );
            }

            var source = query
                .Select(x => new
                {
                    id = x.Id,
                    imie = x.Imie,
                    nazwisko = x.Nazwisko,
                    telefon = x.Telefon
                })
                .ToArray();

            dataGridViewClients.DataSource = source;
        }

        public void LoadModels(string filter = "")
        {
            IQueryable<PhoneModel> query = context.PhoneModel;

            if (!string.IsNullOrWhiteSpace(filter))
            {
                string lowerFilter = filter.ToLower();
                query = query.Where(x =>
                    x.KodModelu.ToLower().Contains(lowerFilter) ||
                    x.Marka.ToLower().Contains(lowerFilter) ||
                    x.PelnaNazwa.ToLower().Contains(lowerFilter)
                );
            }

            var source = query
                .Select(x => new
                {
                    kod_modelu = x.KodModelu,
                    marka = x.Marka,
                    pelna_nazwa = x.PelnaNazwa,
                })
                .ToArray();

            dataGridViewModels.DataSource = source;
        }
        private void AdjustClientTableWidth()
        {
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewClients.AutoResizeColumns();

            int totalWidth = dataGridViewClients.RowHeadersVisible ? dataGridViewClients.RowHeadersWidth : 0;

            foreach (DataGridViewColumn col in dataGridViewClients.Columns)
            {
                if (!col.Visible) continue;
                totalWidth += col.Width;
            }

            totalWidth += 30;
            int padding = 0;

            dataGridViewClients.Width = totalWidth;
            groupBoxClientData.Width = dataGridViewClients.Width + (2 * padding);

            dataGridViewClients.Left = (groupBoxClientData.Width - dataGridViewClients.Width) / 2;

            dataGridViewClients.Refresh();
        }

        private void AdjustModelsTableWidth()
        {
            dataGridViewModels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewModels.AutoResizeColumns();

            int totalWidth = dataGridViewModels.RowHeadersVisible ? dataGridViewModels.RowHeadersWidth : 0;

            foreach (DataGridViewColumn col in dataGridViewModels.Columns)
            {
                if (!col.Visible) continue;
                totalWidth += col.Width;
            }
            totalWidth += 30;

            int padding = 40;

            dataGridViewModels.Width = totalWidth;
            groupBox3.Width = dataGridViewModels.Width + (2 * padding);

            dataGridViewModels.Left = (groupBox3.Width - dataGridViewModels.Width) / 2;

            dataGridViewModels.Refresh();
            this.PerformLayout();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                // walidacja
                if (string.IsNullOrWhiteSpace(textBoxImie.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNazwisko.Text))
                {
                    MessageBox.Show("Imię i nazwisko są wymagane!");
                    return;
                }

                var phoneModel = GetPhoneModelByCode(textBoxModelCode.Text);
                if (phoneModel == null)
                {
                    MessageBox.Show("Nie znaleziono modelu telefonu o podanym kodzie");
                    return;
                }

                // nowa tranzakcja
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // client
                        var client = new Clients
                        {
                            Imie = textBoxImie.Text,
                            Nazwisko = textBoxNazwisko.Text,
                            Telefon = textBoxTelefon.Text
                        };
                        context.Clients.Add(client);
                        context.SaveChanges();  // id klienta do reszty

                        var serviceEntry = new ServiceEntry
                        {
                            IMEI = textBoxImei.Text,
                            Opis = textBoxDesc.Text,
                            CenaWstepna = GetPrice(textBoxFirstPrice.Text),
                            KlientId = client.Id,  // id klienta
                            KodModelu = phoneModel.KodModelu  // model
                        };
                        context.ServiceEntry.Add(serviceEntry);
                        context.SaveChanges();

                        transaction.Commit();
                        MessageBox.Show("Pomyślnie zapisano dane");
                        LoadArrayBox();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Błąd podczas zapisywania danych: {ex.Message}");
                    }
                }
            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"Błąd walidacji: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nieoczekiwany błąd: {ex.Message}");
            }
        }
        private decimal? GetPrice(string text)
        {
            if (!decimal.TryParse(text, out var price))
            {
                throw new ValidationException("To musi być liczba");
            }
            else return price;
        }
        public PhoneModel? GetPhoneModelByCode(string kodModelu)
        {
            return context.PhoneModel
                .FirstOrDefault(pm => pm.KodModelu == kodModelu);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadModels(textBoxSearch.Text);
        }

        private void dataGridViewModels_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewModels.CurrentRow != null &&
            dataGridViewModels.CurrentRow.Cells["kod_modelu"].Value != null)
            {
                textBoxModelCode.Text = dataGridViewModels.CurrentRow.Cells["kod_modelu"].Value.ToString();
            }
        }

        private void textBoxKlientInput_TextChanged(object sender, EventArgs e)
        {
            LoadClients(textBoxKlientInput.Text);
        }

        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewClients.CurrentRow != null &&
                dataGridViewClients.CurrentRow.Cells["imie"].Value != null &&
                dataGridViewClients.CurrentRow.Cells["nazwisko"].Value != null &&
                dataGridViewClients.CurrentRow.Cells["telefon"].Value != null)
            {
                textBoxImie.Text = dataGridViewClients.CurrentRow.Cells["imie"].Value.ToString();
                textBoxNazwisko.Text = dataGridViewClients.CurrentRow.Cells["nazwisko"].Value.ToString();
                textBoxTelefon.Text = dataGridViewClients.CurrentRow.Cells["telefon"].Value.ToString();
            }
        }

        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            foreach (var text in textBoxes)
                text.Text = string.Empty;
        }

        private void buttonAddNewModel_Click(object sender, EventArgs e)
        {

        }
    }
}