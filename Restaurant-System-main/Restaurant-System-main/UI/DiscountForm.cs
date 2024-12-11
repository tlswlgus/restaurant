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
    public partial class DiscountForm : Form
    {
        decimal amount;
        public DiscountForm()
        {
            InitializeComponent();
        }

        string connectionString = "Server=jihyeon\\SQLEXPRESS01;Database=RestaurantDB;Trusted_Connection=True;";

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Prepare the update query with conditional logic
                    string query = "UPDATE Customers SET Discount = @Discount, IsPWD = @IsPWD, IsSeniorCitizen = @IsSeniorCitizen WHERE CustomerID = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Default values
                        decimal discount = 0;
                        bool isPWD = false;
                        bool isSeniorCitizen = false;

                        // Update values based on conditions
                        if (chkPWD.Checked)
                        {
                            isPWD = true;
                            discount = Convert.ToDecimal(0.20);
                        }
                        else if (chkSenior.Checked)
                        {
                            isSeniorCitizen = true;
                            discount = Convert.ToDecimal(0.20);
                        }
                        else if (amount > 0)
                        {
                            discount = amount;
                        }

                        // Bind parameters to the query
                        command.Parameters.AddWithValue("@Discount", discount);
                        command.Parameters.AddWithValue("@IsPWD", isPWD);
                        command.Parameters.AddWithValue("@IsSeniorCitizen", isSeniorCitizen);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Customer details updated successfully.");
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

            this.Close();

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Description, Amount FROM Discounts WHERE Code = @Code";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", txtCode.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string description = reader["Description"].ToString();
                                amount = (decimal)reader["Amount"];
                                lbldesc.Visible = true;
                                lbldesc.Text = description; // Set the lbldesc.Text with Description
                                decimal discountAmount = amount; // Store Amount in a variable
                                lbldesc.ForeColor = System.Drawing.Color.FromArgb(120, 172, 127);
                                Console.WriteLine("Description: " + description);
                                Console.WriteLine("Amount: " + amount);
                            }
                            else
                            {
                                lbldesc.Visible = true;
                                lbldesc.Text = "The code you have entered is invalid";
                                lbldesc.ForeColor = System.Drawing.Color.FromArgb(240, 114, 103);
                                Console.WriteLine("No data found for the provided discount code.");
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

        private void DiscountForm_Load(object sender, EventArgs e)
        {
            chkPWD.Checked = false;
            chkSenior.Checked = false;
        }

        private void chkSenior_CheckStateChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = false;
            btnApply.Enabled = false;
            chkPWD.Checked = false;
            if(!chkSenior.Checked && !chkPWD.Checked)
            {
                txtCode.Enabled = true;
                btnApply.Enabled = true;
            }
        }

        private void chkPWD_CheckStateChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = false;
            btnApply.Enabled = false;
            chkSenior.Checked = false;
            if (!chkSenior.Checked && !chkPWD.Checked)
            {
                btnApply.Enabled = true;
                txtCode.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSenior_Click(object sender, EventArgs e)
        {
            chkSenior.Checked = true;
        }

        private void picPWD_Click(object sender, EventArgs e)
        {
            chkPWD.Checked = true;
        }
    }
}
