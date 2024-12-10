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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            
            int x = (int)((pnlPayment.Width - pnlCredit.Width) * 0.5);
            pnlCredit.Left = x;

            x = (int)((pnlPayment.Width - pnlCash.Width) * 0.15);
            pnlCash.Left = x;

            x = (int)((pnlPayment.Width - pnlWallet.Width) * 0.85);
            pnlWallet.Left = x;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pnlTotalAmount_Paint(object sender, PaintEventArgs e)
        {
            int penSize = 2;
            Pen pen = new Pen(Color.FromArgb(194, 152, 61), penSize);

            //Name Underline
            Point startPoint = new Point(lblLabelTotal.Location.X, lblLabelTotal.Location.Y - 10);
            Point endPoint = new Point(lblTotal.Location.X + lblTotal.Width, lblLabelTotal.Location.Y - 10);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }

        private void pnlCredit_Click(object sender, EventArgs e)
        {
            var notAvailable = new Not_Available();
            notAvailable.ShowDialog();
        }

        private void pnlWallet_Click(object sender, EventArgs e)
        {
            var notAvailable = new Not_Available();
            notAvailable.ShowDialog();
        }

        public void getTotal(string total)
        {
            lblSubtotal.Text = total;
            System.Console.WriteLine(total + " Total");
        }
    }
}
