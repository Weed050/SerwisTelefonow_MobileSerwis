using Microsoft.EntityFrameworkCore;
using SerwisTelefonow.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerwisTelefonow.Models
{
    public partial class SearchServRecords : Form
    {
        private AppDbContext appDbContext;
        public SearchServRecords(AppDbContext _context)
        {
            InitializeComponent();
            CenterFlowLayoutPanel();
            appDbContext = _context;
            wczytajDane();
        }
        private void CenterFlowLayoutPanel()
        {
            int screenCenterX = this.ClientSize.Width / 2;
            int panelCenterX = groupBoxServRecords.Width / 2;
            int panelCenterX2 = dataGridViewClients.Width / 2;

            groupBoxServRecords.Location = new Point(
                screenCenterX - panelCenterX,
                groupBoxServRecords.Location.Y
            );
            dataGridViewClients.Location = new Point(
                screenCenterX - panelCenterX2,
                dataGridViewClients.Location.Y
            );
        }

        private void wczytajDane()
        {
            var source = appDbContext.ServiceEntry.ToArray();
            dataGridViewServRecords.DataSource = source;
            var sourceClients = appDbContext.Clients.ToArray();
            dataGridViewClients.DataSource = sourceClients;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            wczytajDane();
            MessageBox.Show("Odświerzono dane.");
        }
    }
}
