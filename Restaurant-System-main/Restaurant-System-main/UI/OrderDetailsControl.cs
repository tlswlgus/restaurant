using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using RestaurantSystem.Models;
using RestaurantSystem.Utilities;

namespace RestaurantSystem.UI
{
    public partial class OrderDetailsControl : UserControl
    {
        
        int oldQuantity;
        decimal price = 0, oldprice = 0;
        public byte[] OrderImage
        {
            get;
            set;
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

        public decimal TotalPrice {
            get; 
            set;
        }

        string connectionString = "Server=jihyeon\\SQLEXPRESS01;Database=RestaurantDB;Trusted_Connection=True;";


        public void UpdateTotalPrice()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Orders WHERE OrderName = @OrderName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderName", ItemName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Price = Convert.ToDecimal(reader["OrderPrice"]);
                                Quantity = Convert.ToInt32(reader["OrderQuantity"]);
                                TotalPrice = Convert.ToDecimal(reader["OrderTotal"]);
                            }
                            else
                            {
                                Console.WriteLine("Order not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            orderPrice.Text = $"₱ {Price:0.00} x {Quantity}";
            orderTotalPrice.Text = $"₱ {TotalPrice:0.00}";

            var mainFrom = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainFrom != null)
            {
                mainFrom.AddTotalAmount();
            }
        }

        private byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public OrderDetailsControl()
        {
            InitializeComponent();
        }

        private void OrderDetailsControl_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Orders WHERE OrderName = @OrderName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderName", ItemName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Price = Convert.ToDecimal(reader["OrderPrice"]);
                                OrderImage = reader["OrderImage"] as byte[];
                                Quantity = Convert.ToInt32(reader["OrderQuantity"]);
                                TotalPrice = Convert.ToDecimal(reader["OrderTotal"]);
                            }
                            else
                            {
                                Console.WriteLine("Order not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
            picOrder.Image = ImageHelper.ByteArrayToImage(OrderImage);
            orderPrice.Text = $"₱ {Price:0.00} x {Quantity}";
            orderTotalPrice.Text = $"₱ {TotalPrice:0.00}";
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
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Orders WHERE OrderName = @OrderName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderName", ItemName);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected >= 0)
                        {
                            Console.WriteLine("Order deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Order not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            var mainFrom = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainFrom != null)
            {
                mainFrom.AddTotalAmount();
            }
            this.Dispose();
        }

        private void orderName_Click(object sender, EventArgs e)
        {

        }
    }
}


