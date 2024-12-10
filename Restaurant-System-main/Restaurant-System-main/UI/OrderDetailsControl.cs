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
    public partial class OrderDetailsControl : UserControl
    {
        int oldQuantity;
        decimal price = 0, oldprice = 0;
        public Image OrderImage
        {
            get => picOrder.Image;
            set => picOrder.Image = value;
        }

        public string ItemName
        {
            get => orderName.Text;
            set => orderName.Text = value;
        }
        public decimal Price { 
            get; 
            set; 
        }
        public int Quantity { 
            get; 
            set; 
        }


        public void UpdateTotalPrice(Boolean calcu)
        {

            orderPrice.Text = $"₱ {Price} x {Quantity}";
            orderTotalPrice.Text = $"₱ {Price * Quantity}";
            if (calcu == true)
            {
                oldQuantity = Quantity;

                price = (Price * Quantity) - oldprice;
                System.Console.WriteLine(price);

                var mainFrom = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainFrom != null)
                {
                    mainFrom.AddTotalAmount(price);
                }

                oldprice = price;
            } 
            
        }


        public OrderDetailsControl()
        {
            InitializeComponent();
        }

        private void OrderDetailsControl_Load(object sender, EventArgs e)
        {
           
        }

        private void OrderDetailsControl_Paint(object sender, PaintEventArgs e)
        {
            int penSize = 4;
            Pen pen = new Pen(Color.FromArgb(194, 152, 61), penSize);

           
            //Bottom Border
            Point startPoint = new Point(this.Size.Width, this.Size.Height - (penSize / 2));
            Point endPoint = new Point(0, this.Size.Height - (penSize / 2));
            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }

        private void orderPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            price = 0 - (Price * Quantity);

            var mainFrom = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainFrom != null)
            {
                mainFrom.AddTotalAmount(price);
            }
            this.Dispose();
        }

        private void orderName_Click(object sender, EventArgs e)
        {

        }
    }
}


