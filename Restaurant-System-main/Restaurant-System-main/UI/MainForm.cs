using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RestaurantSystem.Data;
using RestaurantSystem.Handler;
using RestaurantSystem.Models;
using RestaurantSystem.UI;

namespace RestaurantSystem.UI
{
    public partial class MainForm : Form
    {
        private readonly MenuEventHandler _menuButtonHandler;
        private List<OrderDetailsControl> orderedItemControls = new List<OrderDetailsControl>();
        decimal totalAmount = 0;
        Boolean dineIn;
        decimal totalOrderAmount;
        string connectionString = "Server=jihyeon\\SQLEXPRESS01;Database=RestaurantDB;Trusted_Connection=True;";
        public FlowLayoutPanel OrderDetailsPanel => flpOrderDetails;
        public MainForm()
        {
            InitializeComponent();
            var databaseHandler = new DatabaseHandler();
            
            _menuButtonHandler = new MenuEventHandler(databaseHandler, flpMenuItem, flpOrderDetails);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            totalAmount = 0;
            lblTotalAmount.Text = "₱ 00.00";
            flpOrderDetails.Controls.Clear();
            string connectionString = "Server=jihyeon\\SQLEXPRESS01;Database=RestaurantDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string truncateQuery = "TRUNCATE TABLE Orders";
                    using (SqlCommand command = new SqlCommand(truncateQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                UPDATE Customers
                SET 
                    Name = NULL,
                    ContactNumber = NULL,
                    PaymentOption = NULL,
                    Discount = NULL,
                    IsPWD = NULL,
                    IsSeniorCitizen = NULL,
                    Subtotal = NULL,
                    Tax = NULL,
                    Total = NULL,
                    DineIn = NULL
                WHERE CustomerID = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        Console.WriteLine(rowsAffected + " rows updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            var launch = new Launch();
            _menuButtonHandler.LoadMenuItems();
            launch.ShowDialog();
        }
        
        private void btnAll_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems();
        }
        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems("Appetizers");
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems("Desserts");
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems("Main Course");
        }

        private void Beverages_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems("Beverages");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            _menuButtonHandler.LoadMenuItems("All", searchTerm);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            var uiHostNoLaunch = new UIHostNoLaunch();
            var tipInvocation = (ITipInvocation)uiHostNoLaunch;
            tipInvocation.Toggle(GetDesktopWindow());
            Marshal.ReleaseComObject(uiHostNoLaunch);
        }

        [ComImport, Guid("4ce576fa-83dc-4F88-951c-9d0782b4e376")]
        class UIHostNoLaunch
        {
        }

        [ComImport, Guid("37c994e7-432b-4834-a2f7-dce1f13b834b")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        interface ITipInvocation
        {
            void Toggle(IntPtr hwnd);
        }

        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();

        private void pnlDuscount_Paint(object sender, PaintEventArgs e)
        {
            int penSize = 2;
            Pen pen = new Pen(Color.FromArgb(194, 152, 61), penSize);

            //Top Border
            Point startPoint = new Point(0, 0 + (penSize / 2));
            Point endPoint = new Point(pnlDuscount.Size.Width, 0 + (penSize / 2));
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Right Border
            startPoint = new Point(pnlDuscount.Size.Width - (penSize / 2), 0);
            endPoint = new Point(pnlDuscount.Size.Width - (penSize / 2), pnlDuscount.Size.Height);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Bottom Border
            startPoint = new Point(pnlDuscount.Size.Width, pnlDuscount.Size.Height - (penSize / 2));
            endPoint = new Point(0, pnlDuscount.Size.Height - (penSize / 2));
            e.Graphics.DrawLine(pen, startPoint, endPoint);
            //Left Border
            startPoint = new Point(0 + (penSize / 2), pnlDuscount.Size.Height);
            endPoint = new Point(0 + (penSize / 2), 0);
            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }

        private void pnlAmount_Paint(object sender, PaintEventArgs e)
        {
            int penSize = 4;
            Pen pen = new Pen(Color.FromArgb(194, 152, 61), penSize);

            Point startPoint = new Point(pnlAmount.Size.Width, pnlAmount.Size.Height - (penSize / 2));
            Point endPoint = new Point(0, pnlAmount.Size.Height - (penSize / 2));
            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void AddTotalAmount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COALESCE(SUM(OrderTotal), 0) AS TotalOrderAmount FROM Orders;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totalOrderAmount = reader.GetDecimal(0);
                                lblTotalAmount.Text = $"₱ {totalOrderAmount:0.00}";
                                Console.WriteLine("Total Order Amount: " + totalOrderAmount);
                            }
                            else
                            {
                                Console.WriteLine("No data found.");
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

        public void getDineIn(Boolean dine) { 
            dineIn = dine;
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (totalOrderAmount > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Customers SET Subtotal = @NewSubtotal WHERE CustomerID = 1";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NewSubtotal", totalOrderAmount);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Subtotal updated successfully for CustomerID = 1");
                            }
                            else
                            {
                                Console.WriteLine("No customer found with CustomerID = 1");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                var checkout = new Checkout();
                checkout.ShowDialog();
                checkout = Application.OpenForms.OfType<Checkout>().FirstOrDefault();
                if (checkout != null)
                {
                    checkout.getTotal();
                }
                


            }
            else
            {
                MessageBox.Show("Please select your order.", "No Order(s) Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            var launch = new Launch();

            _menuButtonHandler.LoadMenuItems("All", searchTerm);
            totalAmount = 0;
            lblTotalAmount.Text = "₱ 00.00";
            flpOrderDetails.Controls.Clear();
            string connectionString = "Server=jihyeon\\SQLEXPRESS01;Database=RestaurantDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string truncateQuery = "TRUNCATE TABLE Orders";
                    using (SqlCommand command = new SqlCommand(truncateQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                UPDATE Customers
                SET 
                    Name = NULL,
                    ContactNumber = NULL,
                    PaymentOption = NULL,
                    Discount = NULL,
                    IsPWD = NULL,
                    IsSeniorCitizen = NULL,
                    Subtotal = NULL,
                    Tax = NULL,
                    Total = NULL,
                    DineIn = NULL
                WHERE CustomerID = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        Console.WriteLine(rowsAffected + " rows updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            launch.Show();
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            var discountFrom = new DiscountForm();
            discountFrom.ShowDialog();
        }
    }
}
