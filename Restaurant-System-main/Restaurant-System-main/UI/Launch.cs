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
    public partial class Launch : Form
    {
        Boolean dineIn;
        int outerBorder = 35;
        public Launch()
        {
            InitializeComponent();
        }

        private void Launch_Paint(object sender, PaintEventArgs e)
        {
            int penSize = 15;
            Pen pen = new Pen(Color.FromArgb(194, 152, 61), penSize);
            
            
            //Top Border
            Point startPoint = new Point(outerBorder, outerBorder + 7);
            Point endPoint = new Point(this.Size.Width - outerBorder, outerBorder + 7);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Right Border
            startPoint = new Point(this.Size.Width - outerBorder, outerBorder);
            endPoint = new Point(this.Size.Width - outerBorder, this.Size.Height - outerBorder);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Bottom Border
            startPoint = new Point(this.Size.Width - outerBorder, this.Size.Height - outerBorder - 8);
            endPoint = new Point(outerBorder, this.Size.Height - outerBorder - 8);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Left Border
            startPoint = new Point(outerBorder, this.Size.Height - outerBorder);
            endPoint = new Point(outerBorder, outerBorder);
            e.Graphics.DrawLine(pen, startPoint, endPoint);

            penSize = 7;
            pen = new Pen(Color.FromArgb(194, 152, 61), penSize);
            startPoint = new Point(outerBorder, Convert.ToInt32(this.Height * 0.25));
            endPoint = new Point(this.Size.Width - outerBorder, Convert.ToInt32(this.Height * 0.25));
            e.Graphics.DrawLine(pen, startPoint, endPoint);

            startPoint = new Point(outerBorder, Convert.ToInt32(this.Height * 0.75));
            endPoint = new Point(this.Size.Width - outerBorder, Convert.ToInt32(this.Height * 0.75));
            e.Graphics.DrawLine(pen, startPoint, endPoint);

        }

        private void pnlLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Launch_Load(object sender, EventArgs e)
        {
            pnlLabel.Left = (this.Size.Width - pnlLabel.Size.Width) / 2;
            pnlLabel.Top = (this.Size.Height - pnlLabel.Size.Height) / 14;

            pnlClick.Height =  Convert.ToInt32(this.Height * 0.5) - 8;
            pnlClick.Width = Convert.ToInt32(this.Width * 0.25);
            pnlClick.Left = (this.Size.Width - pnlClick.Size.Width) / 2;
            pnlClick.Top = (this.Size.Height - pnlClick.Size.Height) / 2 + 1;

            picStart.Left = (pnlClick.Size.Width - picStart.Size.Width) / 2;

            lblStart.MaximumSize = new Size(pnlClick.Width, 0);
            lblStart.Left = (pnlClick.Size.Width - lblStart.Size.Width) / 2;

            btnDine.Left = (pnlClick.Size.Width - btnDine.Size.Width) / 2;
            btnTake.Left = (pnlClick.Size.Width - btnTake.Size.Width) / 2;

            picBGStart.Height = Convert.ToInt32(this.Height * 0.5) - 8;
            picBGStart.Width = this.Width;
            picBGStart.MaximumSize = new Size((picBGStart.Size.Width - (outerBorder * 2) - 15), picBGStart.Height);
            picBGStart.Left = (this.Size.Width - picBGStart.Size.Width) / 2 + 1;
            picBGStart.Top = (this.Size.Height - picBGStart.Size.Height) / 2 + 1;
        }

        private void pnlClick_Paint(object sender, PaintEventArgs e)
        {
            int penSize = 4;
            Pen pen = new Pen(Color.FromArgb(194, 152, 61), penSize);

            //Top Border
            Point startPoint = new Point(picStart.Location.X, picStart.Location.Y - (penSize / 2));
            Point endPoint = new Point(picStart.Location.X + picStart.Width, picStart.Location.Y - (penSize/2));
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Right Border
            startPoint = new Point(picStart.Location.X + picStart.Width + (penSize / 2), picStart.Location.Y - (penSize / 2) - 2);
            endPoint = new Point(picStart.Location.X + picStart.Width + (penSize / 2), picStart.Size.Height + picStart.Location.Y);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Bottom Border
            startPoint = new Point(picStart.Location.X + picStart.Width + penSize, picStart.Size.Height + picStart.Location.Y + (penSize / 2));
            endPoint = new Point(picStart.Location.X - penSize, picStart.Size.Height + picStart.Location.Y + (penSize / 2));
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Left Border
            startPoint = new Point(picStart.Location.X - (penSize / 2), picStart.Location.Y - (penSize / 2) - 2);
            endPoint = new Point(picStart.Location.X - (penSize / 2), picStart.Size.Height + picStart.Location.Y);
            e.Graphics.DrawLine(pen, startPoint, endPoint);

            penSize = 3;
            pen = new Pen(Color.FromArgb(194, 152, 61), penSize);
            startPoint = new Point(lblStart.Location.X + lblStart.Width - 10, lblStart.Size.Height + lblStart.Location.Y + 10);
            endPoint = new Point(lblStart.Location.X + 10, lblStart.Size.Height + lblStart.Location.Y + 10);
            e.Graphics.DrawLine(pen, startPoint, endPoint);

            penSize = 7;
            pen = new Pen(Color.FromArgb(194, 152, 61), penSize);
            startPoint = new Point(this.Location.X + (penSize / 2), 0);
            endPoint = new Point(this.Location.X + (penSize / 2), this.Size.Height);
            e.Graphics.DrawLine(pen, startPoint, endPoint);

            startPoint = new Point(pnlClick.Width - (penSize / 2), 0);
            endPoint = new Point(pnlClick.Width - (penSize / 2), this.Size.Height);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }

        private void btnDine_Click(object sender, EventArgs e)
        {
            dineIn = true;
            Close();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            dineIn = false;
            Close();
        }
    }
}
