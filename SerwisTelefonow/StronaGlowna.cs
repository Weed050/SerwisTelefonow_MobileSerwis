using SerwisTelefonow.Data;
using SerwisTelefonow.DBModels;
using System.Reflection.Metadata.Ecma335;

namespace SerwisTelefonow
{
    public partial class StronaGlowna : Form
    {
        private readonly AppDbContext _context;
        public StronaGlowna(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            PanelAdministratora adminPanel = new PanelAdministratora(_context);
            adminPanel.Show();
            this.Hide();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxLogin.Text, out int result))
            {
                MessageBox.Show("Nie podano prawid³owego loginu");
            }
            else
            {
                var serwis = _context.ServiceEntry.Where(p => p.Id == result && p.CenaWstepna != null && p.CenaKoncowa == null);
                if (serwis.Any())
                    MessageBox.Show($"Jeszcze serwis siê nie zakoñczy³. Telefon jest jeszcze w naprawie.","Przykro nam.");
                else
                    MessageBox.Show($"Serwis zosta³ ukoñczony. Telefon jest do odebrania.", "Zapraszamy.");
                textBoxLogin.Text = "";
            }
        }
    }
}
