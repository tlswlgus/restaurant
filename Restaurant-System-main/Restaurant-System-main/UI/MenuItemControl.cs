using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantSystem.UI
{
    public partial class MenuItemControl : UserControl
    {
        
        public MenuItemControl()
        {
            InitializeComponent();
        }

        public string ItemName
        {
            get => lblItemName.Text;
            set => lblItemName.Text = value;
        }

        public string ItemDescription
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }

        public decimal Price
        {
            get => decimal.Parse(lblPrice.Text.Substring(1));
            set => lblPrice.Text = $"\u20b1 {value:0.00}";
        }

        public Image ItemImage
        {
            get => pictureBox.Image;
            set => pictureBox.Image = value;
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblItemName_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void MenuItemControl_Load(object sender, EventArgs e)
        {
            pictureBox.Left = (this.Size.Width - pictureBox.Size.Width) / 2;
            lblDescription.Left = (this.Size.Width - lblDescription.Size.Width) / 2;
            lblItemName.Left = (this.Size.Width - lblItemName.Size.Width) / 2;
            lblPrice.Left = (this.Size.Width - lblPrice.Size.Width) / 2;
        }

        private void MenuItemControl_Paint(object sender, PaintEventArgs e)
        {
            int penSize = 4;
            Pen pen = new Pen(Color.FromArgb(194, 152, 61), penSize);
            
            //Top Border
            Point startPoint = new Point(0, 0 + (penSize / 2));
            Point endPoint = new Point(this.Size.Width, 0 + (penSize / 2));
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Right Border
            startPoint = new Point(this.Size.Width - penSize, 0) ;
            endPoint = new Point(this.Size.Width - penSize, this.Size.Height);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Bottom Border
            startPoint = new Point(this.Size.Width, this.Size.Height - penSize);
            endPoint = new Point(0, this.Size.Height - penSize);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Left Border
            startPoint = new Point(0 + (penSize / 2), this.Size.Height);
            endPoint = new Point(0 , 0);
            e.Graphics.DrawLine(pen, startPoint, endPoint);

        }
    }
}
