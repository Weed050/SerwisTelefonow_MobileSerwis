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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerwisTelefonow.Models
{
    public partial class AddNewServRecord : Form
    {
        private readonly AppDbContext context;
        public AddNewServRecord(AppDbContext _context)
        {
            InitializeComponent();
            context = _context;
            LoadArrayBox();
            AlignBoxesInForm();
            AdjustGroupBoxWidthData();
        }
        public void LoadArrayBox()
        {
            var source = context.PhoneModel
                .Select(x => new {  
                    kod_modelu = x.KodModelu,
                    marka = x.Marka,
                    pelna_nazwa = x.PelnaNazwa,
                }).ToArray();
                
            dataGridViewModels.DataSource = source;
        }
        private void AdjustGroupBoxWidthData()
        {
            dataGridViewModels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewModels.AutoResizeColumns();

            int totalWidth = dataGridViewModels.RowHeadersVisible ? dataGridViewModels.RowHeadersWidth : 0;

            foreach (DataGridViewColumn col in dataGridViewModels.Columns)
            {
                totalWidth += col.Width;
            }
            dataGridViewModels.Width = totalWidth;
            groupBox3.Width = dataGridViewModels.Width;
        }

        private void AlignBoxesInForm()
        {
            int totalWidth = this.ClientSize.Width;
            int box1Width = groupBox1.Width;
            int box3Width = groupBox3.Width;

            int spacing = (totalWidth - box1Width - box3Width) / 3;

            // Pozycje: odstęp | box1 | odstęp | box3 | odstęp
            groupBox1.Location = new Point(spacing, groupBox1.Location.Y);
            groupBox3.Location = new Point(spacing * 2 + box1Width, groupBox3.Location.Y);
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

                        // Tworzenie i zapis wpisu serwisowego
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
    } }