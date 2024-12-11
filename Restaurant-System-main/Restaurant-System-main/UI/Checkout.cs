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
    public partial class Checkout : Form
    {
        string connectionString = "Server=jihyeon\\SQLEXPRESS01;Database=RestaurantDB;Trusted_Connection=True;";
        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            getTotal();
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
            chkCredit.Checked = true;
        }

        private void pnlWallet_Click(object sender, EventArgs e)
        {
            chkWallet.Checked = true;
        }

        public void getTotal()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Subtotal, ISNULL(Discount, 0) AS Discount FROM Customers WHERE CustomerID = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal subtotal = (decimal)reader["Subtotal"];
                                decimal discount = (decimal)reader["Discount"];

                                decimal tax = subtotal * 0.12m; 
                                decimal total = subtotal + tax - (subtotal * discount);

                                // Update the labels
                                lblSubtotal.Text = $"₱ {subtotal:0.00}";
                                lblVAT.Text = $"₱ {tax:0.00}";
                                lblDiscount.Text = $"₱ {subtotal * discount:0.00}";
                                lblTotal.Text = $"₱ {total:0.00}";

                                Console.WriteLine("Subtotal: " + subtotal);
                                Console.WriteLine("Tax: " + tax);
                                Console.WriteLine("Discount: " + subtotal * discount);
                                Console.WriteLine("Total: " + total);
                            }
                            else
                            {
                                Console.WriteLine("No data found for the provided CustomerID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void pnlCash_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlCash_Click(object sender, EventArgs e)
        {
            chkCash.Checked = true;
        }

        private void chkCredit_CheckedChanged(object sender, EventArgs e)
        {
            chkCash.Checked = false;
            chkWallet.Checked = false;
        }

        private void chkCash_CheckedChanged(object sender, EventArgs e)
        {
            chkCredit.Checked = false;
            chkWallet.Checked = false;
        }

        private void chkWallet_CheckedChanged(object sender, EventArgs e)
        {
            chkCash.Checked = false;
            chkCredit.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("Please fill in the Name and Contact Number fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if at least one checkbox is checked
            if (!chkCash.Checked && !chkCredit.Checked && !chkWallet.Checked)
            {
                MessageBox.Show("Please select a payment option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                UPDATE Customers
                SET 
                    Name = @Name, 
                    Discount = @Discount, 
                    Tax = @Tax, 
                    ContactNumber = @ContactNumber, 
                    Subtotal = @Subtotal, 
                    Total = @Total, 
                    PaymentOption = @PaymentOption
                WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        Console.WriteLine("1");
                        string name = txtName.Text;
                        string contactNumber = txtNumber.Text;
                        decimal subtotal = decimal.Parse(lblSubtotal.Text.Trim('₱', ' '));
                        decimal tax = decimal.Parse(lblVAT.Text.Trim('₱', ' '));
                        decimal discount = decimal.Parse(lblDiscount.Text.Trim('₱', ' ')); 
                        decimal total = decimal.Parse(lblTotal.Text.Trim('₱', ' ')); 
                        string paymentOption = "";

                        Console.WriteLine("2");
                        if (chkCash.Checked)
                        {
                            paymentOption = "Cash";
                        }
                        else if (chkCredit.Checked)
                        {
                            paymentOption = "Credit";
                        }
                        else if (chkWallet.Checked)
                        {
                            paymentOption = "Wallet";
                        }

                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Discount", discount);
                        command.Parameters.AddWithValue("@Tax", tax);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@Subtotal", subtotal);
                        command.Parameters.AddWithValue("@Total", total);
                        command.Parameters.AddWithValue("@PaymentOption", paymentOption);
                        command.Parameters.AddWithValue("@CustomerID", 1);

                        int rowsAffected = command.ExecuteNonQuery();

                        var orderComplete = new OrderComplete();
                        orderComplete.ShowDialog();
                        this.Close();
                        
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Customer details updated successfully for CustomerID = 1.");
                        }
                        else
                        {
                            Console.WriteLine("No customer found with CustomerID = 1.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
