using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.UI
{

        public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }
        string connectionString = "Server=jihyeon\\SQLEXPRESS01;Database=RestaurantDB;Trusted_Connection=True;";

        private void Receipt_Load(object sender, EventArgs e)
        {
            LoadCustomerDetails();
            LoadOrders();
        }

        public void LoadOrders()
        {
            string sql = "SELECT OrderName, OrderQuantity, OrderTotal FROM Orders";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order
                            {
                                OrderName = reader["OrderName"].ToString(),
                                OrderQuantity = Convert.ToInt32(reader["OrderQuantity"]),
                                OrderTotal = Convert.ToDecimal(reader["OrderTotal"])
                            };
                            CreateOrderPanel(order);
                        }
                    }
                }
            }
        }

        private void CreateOrderPanel(Order order)
        {
            Panel panel = new Panel
            {
                Size = new Size(556, 36),
                BorderStyle = BorderStyle.None
            };

            Label label1 = new Label
            {
                Text = $"₱ {order.OrderQuantity} {order.OrderName}",
                Location = new Point(10, 5),
                AutoSize = false,
                Size = new Size(396, 25),
                Font = new Font("Georgia", 15.75F),
                ForeColor = Color.FromArgb(194, 152, 61)
            };

            Label label2 = new Label
            {
                Text = string.Format("₱{0:N2}", order.OrderTotal),
                Location = new Point(412, 5),
                AutoSize = false,
                Size = new Size(134, 23),
                Font = new Font("Georgia", 15.75F),
                ForeColor = Color.FromArgb(213, 207, 196),
                TextAlign = ContentAlignment.MiddleRight
            };

            panel.Controls.Add(label1);
            panel.Controls.Add(label2);
            flpOrder.Controls.Add(panel);
        }

        public void LoadCustomerDetails()
        { 
            string sql = "SELECT Name, Discount, ContactNumber, PaymentOption, Tax, Total, DineIn FROM Customers WHERE CustomerID = 1";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblName.Text = reader["Name"].ToString();
                                lblNumber.Text = reader["ContactNumber"].ToString();
                                lblPayment.Text = reader["PaymentOption"].ToString();
                                lblDine.Text = (bool)reader["DineIn"] ? "DINE-IN" : "TAKE-OUT";
                                lblDateTime.Text = DateTime.Now.ToString("MM/dd/yy HH:mm:ss");
                                lblDiscount.Text = "₱" + reader["Discount"].ToString();
                                lblTax.Text = "₱" + reader["Tax"].ToString();
                                lblTotal.Text = "₱" + reader["Total"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while fetching data: {ex.Message}");
            }
        }

    }
}
