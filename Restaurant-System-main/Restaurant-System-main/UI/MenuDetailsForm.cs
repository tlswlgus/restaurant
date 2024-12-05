using RestaurantSystem.Data;
using RestaurantSystem.Handler;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace RestaurantSystem.UI
{
    public partial class MenuDetailsForm : Form
    {
        
        public MenuDetailsForm()
        {
            InitializeComponent();
        } 

        public string ItemNameDetails
        {
            get => itemName.Text;
            set => itemName.Text = value;
        }

        public string ItemDescriptionDetails
        {
            get => itemDescription.Text;
            set => itemDescription.Text = value;
        }
        public decimal ItemPriceDetails
        {
            get => decimal.Parse(itemPriceDetails.Text.Substring(1));
            set => itemPriceDetails.Text = $"\u20b1 {value:0.00}";
        }

        public string ItemListIngredientsDetails
        {
            get => listIngredients.Text;
            set => listIngredients.Text = value;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuDetailsForm_Load(object sender, EventArgs e)
        {
            itemName.Left = (pnlDetailRight.Size.Width - itemName.Size.Width) / 2;
        }

        private void MenuDetailsForm_Paint(object sender, PaintEventArgs e)
        {
            int penSize = 4;
            Pen pen = new Pen(Color.FromArgb(194, 152, 61), penSize);

            //Top Border
            Point startPoint = new Point(0, 0 + (penSize / 2));
            Point endPoint = new Point(this.Size.Width, 0 + (penSize / 2));
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Right Border
            startPoint = new Point(this.Size.Width - (penSize / 2), 0);
            endPoint = new Point(this.Size.Width - (penSize / 2), this.Size.Height);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Bottom Border
            startPoint = new Point(this.Size.Width, this.Size.Height - (penSize / 2));
            endPoint = new Point(0, this.Size.Height - (penSize / 2));
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Left Border
            startPoint = new Point(0 + (penSize / 2), this.Size.Height);
            endPoint = new Point(0 + (penSize / 2), 0);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            
        }

        private void pnlDetailRight_Paint(object sender, PaintEventArgs e)
        {
            int penSize = 2;
            Pen pen = new Pen(Color.FromArgb(194, 152, 61), penSize);

            //Name Underline
            Point startPoint = new Point(0, itemName.Location.Y + itemName.Size.Height + 5);
            Point endPoint = new Point(pnlDetailRight.Size.Width, itemName.Location.Y + itemName.Size.Height + 5);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            startPoint = new Point(0, itemDescription.Location.Y + itemDescription.Size.Height + 5);
            endPoint = new Point(pnlDetailRight.Size.Width, itemDescription.Location.Y + itemDescription.Size.Height + 5);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            if (quantity != 99)
            {
                lblQuantity.Text = (quantity + 1).ToString();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lblQuantity.Text);
            if (quantity != 0)
            {
                lblQuantity.Text = (quantity - 1).ToString();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void itemDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
