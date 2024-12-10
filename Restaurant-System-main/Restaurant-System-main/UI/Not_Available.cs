using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.UI
{
    public partial class Not_Available : Form
    {
        public Not_Available()
        {
            InitializeComponent();
        }

        private void Not_Available_Load(object sender, EventArgs e)
        {
            int x = (int)((pnlTop.Width - lblSorry.Width) * 0.5);
            lblSorry.Left = x;
            x = (int)((pnlTop.Width - picSorry.Width) * 0.5);
            picSorry.Left = x;
            x = (int)((pnlTop.Width - btnOK.Width) * 0.5);
            btnOK.Left = x;
            x = (int)((pnlTop.Width - lblNotAvail.Width) * 0.5);
            lblNotAvail.Left = x;
        }
    }
}
