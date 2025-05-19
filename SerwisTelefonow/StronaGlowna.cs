namespace SerwisTelefonow
{
    public partial class StronaGlowna : Form
    {
        public StronaGlowna()
        {
            InitializeComponent();
        }

        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            PanelAdministratora adminPanel = new PanelAdministratora();
            adminPanel.Show();
            this.Hide();
        }
    }
}
