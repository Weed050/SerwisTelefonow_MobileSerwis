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
        public SearchServRecords(AppDbContext _context)
        {
            InitializeComponent();
            CenterFlowLayoutPanel();

            var source = _context.ServiceEntry.ToArray();
            dataGridViewServRecords.DataSource = source;
        }
        private void CenterFlowLayoutPanel()
        {
            int screenCenterX = this.ClientSize.Width / 2;
            int screenCenterY = this.ClientSize.Height / 2;

            int panelCenterX = groupBoxServRecords.Width / 2;
            int panelCenterY = groupBoxServRecords.Height / 2;

            groupBoxServRecords.Location = new Point(
                screenCenterX - panelCenterX,
                screenCenterY - panelCenterY
            );
        }
    }
}
