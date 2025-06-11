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
            if (!TryParseServiceCode(textBoxLogin.Text, out int serviceEntryId, out int clientId))
            {
                MessageBox.Show("Nie podano prawid³owego kodu logowania");
                return;
            }

            // Przyk³adowa walidacja wpisu serwisowego – zmodyfikuj kryteria wed³ug potrzeb
            var serwis = _context.ServiceEntry
                                 .Where(p => p.Id == serviceEntryId
                                          && p.CenaWstepna != null
                                          && p.CenaKoncowa == null);

            if (serwis.Any())
                MessageBox.Show("Jeszcze serwis siê nie zakoñczy³. Telefon jest jeszcze w naprawie.", "Przykro nam.");
            else
                MessageBox.Show("Serwis zosta³ ukoñczony. Telefon jest do odebrania.", "Zapraszamy.");

            textBoxLogin.Text = "";
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


        private void StronaGlowna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
