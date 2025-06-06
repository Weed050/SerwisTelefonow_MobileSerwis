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

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new Clients
                {
                    Imie = textBoxImie.Text,
                    Nazwisko = textBoxNazwisko.Text,
                    Telefon = textBoxTelefon.Text
                };
                //var phoneModel = new PhoneModel
                //{
                //    KodModelu = GenerateModelCode(), // lub pobierz z kontrolki
                //    Marka = ValidateAndGetText(textBox4, "Marka"),
                //    PelnaNazwa = ValidateAndGetText(textBox2, "Model telefonu")
                //};
                var serviceEntry = new ServiceEntry
                {
                    IMEI = textBoxImei.Text,
                    Opis = textBoxDesc.Text,
                    CenaWstepna = GetPrice(textBoxFirstPrice.Text),
                    Client = client,
                    Model = new PhoneModel
                    {

                        KodModelu = "MI12PRO",
                        Marka = "Xiaomi",
                        PelnaNazwa = "Xiaomi 12 Pro"
                    },
                };
                context.Clients.Add(client);
                context.ServiceEntry.Add(serviceEntry);
                context.SaveChanges();
                MessageBox.Show("Pomyślnie zapisano dane");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zczytywania danych.");
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
    } }
