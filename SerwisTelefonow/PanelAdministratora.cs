using SerwisTelefonow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwisTelefonow
{
    public partial class PanelAdministratora : Form
    {
        private Form currentForm = null;
        public PanelAdministratora()
        {
            InitializeComponent();
            AddNewServRecord addNewServRecord = new AddNewServRecord();
            OpenFormInPanel(addNewServRecord);
        }

        private void OpenForm(Form form)
        {
            if (form != null)
            {
                currentForm.Close();
            }
            OpenFormInPanel(form);
        }
        private void OpenFormInPanel(Form form)
        {
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void dodajWpisSerwisuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServRecord addNewServRecord = new AddNewServRecord();
            OpenForm(addNewServRecord);
        }

        private void PanelAdministratora_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void przegladajWpisyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchServRecords searchServRecords = new SearchServRecords();
            OpenForm(searchServRecords);
        }

        private void wyświetlFakturyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showInvoices showInvoices = new showInvoices();
            OpenForm(showInvoices);
        }

        private void dodajFakturęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInvoice addInvoice = new AddInvoice();
            OpenForm(addInvoice);
        }

        private void sprawdźModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckModel checkModel = new CheckModel();
            OpenForm(checkModel);
        }

        private void wycenaNaprawyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckServisPrice checkServisPrice = new CheckServisPrice();
            OpenForm(checkServisPrice);
        }
    }
}
