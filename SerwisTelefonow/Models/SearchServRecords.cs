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
        public SearchServRecords()
        {
            InitializeComponent();
            CenterFlowLayoutPanel();
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
