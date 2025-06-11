using Microsoft.EntityFrameworkCore;
using SerwisTelefonow.Data;
using SerwisTelefonow.DBModels;
using SerwisTelefonow.Models;

namespace SerwisTelefonow
{
    public partial class PanelAdministratora : Form
    {
        private readonly AppDbContext context;
        private Form currentForm = null;
        public PanelAdministratora(AppDbContext _context)
        {
            InitializeComponent();
            context = _context;
            AddNewServRecord addNewServRecord = new AddNewServRecord(context);
            OpenFormInPanel(addNewServRecord);
            CenterFlowLayoutPanel();
        }
        private void CenterFlowLayoutPanel()
        {
            int screenCenterX = this.ClientSize.Width / 2;
            int screenCenterY = this.ClientSize.Height / 2;

            int panelCenterX = panel1.Width / 2;
            int panelCenterY = panel1.Height / 2;

            panel1.Location = new Point(
                screenCenterX - panelCenterX,
                screenCenterY - panelCenterY
            );
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
            AddNewServRecord addNewServRecord = new AddNewServRecord(context);
            OpenForm(addNewServRecord);
        }



        private void przegladajWpisyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchServRecords searchServRecords = new SearchServRecords(context);
            OpenForm(searchServRecords);
        }

        private void wylogujSięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StronaGlowna stronaGlowna = new StronaGlowna(context);
            stronaGlowna.Show();
            this.Hide();
        }

        private void PanelAdministratora_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
