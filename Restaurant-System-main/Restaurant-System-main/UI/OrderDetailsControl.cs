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
        public string ItemName
        {
            get => orderName.Text;

            set => orderName.Text = value;
        }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public void UpdateTotalPrice()
        {
            orderTotalPrice.Text = $"\u20b1 {Price * Quantity:0.00}";
        }

        public OrderDetailsControl()
        {
            InitializeComponent();
        }
    }
}


