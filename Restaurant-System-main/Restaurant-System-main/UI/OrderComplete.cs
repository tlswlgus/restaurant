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
    public partial class OrderComplete : Form
    {
        public OrderComplete()
        {
            InitializeComponent();
        }
        string connectionString = "Server=jihyeon\\SQLEXPRESS01;Database=RestaurantDB;Trusted_Connection=True;";
        private void OrderComplete_Load(object sender, EventArgs e)
        {
            int x = (int)((pnlTop.Width - lblComplete.Width) * 0.5);
            lblComplete.Left = x;
            x = (int)((pnlTop.Width - lblLabelAmount.Width) * 0.5);
            lblLabelAmount.Left = x;
            x = (int)((pnlTop.Width - lblAmount.Width) * 0.5);
            lblAmount.Left = x;
            x = (int)((pnlTop.Width - picCheck.Width) * 0.5);
            picCheck.Left = x;
            LoadCustomerTotal();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var receipt = new Receipt();
            receipt.ShowDialog();

            receipt = Application.OpenForms.OfType<Receipt>().FirstOrDefault();
            if (receipt != null)
            {
                receipt.LoadOrders();
                receipt.LoadCustomerDetails();
            }
        }

        private void LoadCustomerTotal()
        {
            string sql = "SELECT Total FROM Customers WHERE CustomerID = 1";

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
                                lblAmount.Text = "₱" + reader["Total"].ToString();
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


        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
