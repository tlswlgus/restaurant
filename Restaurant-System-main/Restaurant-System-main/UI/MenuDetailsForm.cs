using RestaurantSystem.Data;
using RestaurantSystem.Handler;
using RestaurantSystem.Models;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace RestaurantSystem.UI
{
    public partial class MenuDetailsForm : Form
    {
        private readonly Action<OrderDetailsControl> onOrder;
        public MenuDetailsForm(Action<OrderDetailsControl> onOrder)
        {
            InitializeComponent();
            this.onOrder = onOrder;
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
            set => itemPriceDetails.Text = $"₱ {value:0.00}";
        }

        public string ItemListIngredientsDetails
        {
            get => listIngredients.Text;
            set => listIngredients.Text = value;
        }

        public Image ItemImage
        {
           get => itemImage.Image;
           set => itemImage.Image = value;
        }

        int oldQuantity;

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
            int quantity = int.Parse(lblQuantity.Text); // Get the quantity selected by the user
            quantity = oldQuantity + quantity;
            string connectionString = "Server=jihyeon\\SQLEXPRESS01;Database=RestaurantDB;Trusted_Connection=True;";
            
            if (quantity > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string checkQuery = "SELECT COUNT(*) FROM Orders WHERE OrderName = @OrderName";
                        byte[] imageBytes = ImageToByteArray(ItemImage);
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("OrderName", ItemNameDetails);
                            int count = (int)checkCommand.ExecuteScalar();
                            if (count == 0)
                            {
                                // Insert new product
                                string insertQuery = "INSERT INTO Orders (OrderName, OrderPrice, OrderImage, OrderQuantity, OrderTotal) VALUES (@OrderName, @OrderPrice, @OrderImage, @OrderQuantity, @OrderTotal)";
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@OrderName", ItemNameDetails);
                                    insertCommand.Parameters.AddWithValue("@OrderPrice", ItemPriceDetails);
                                    insertCommand.Parameters.AddWithValue("@OrderImage", imageBytes);
                                    insertCommand.Parameters.AddWithValue("@OrderQuantity", quantity);
                                    insertCommand.Parameters.AddWithValue("@OrderTotal", ItemPriceDetails * quantity);
                                    insertCommand.ExecuteNonQuery();

                                    oldQuantity = quantity;

                                }
                            }
                            else
                            {
                                string query = "SELECT OrderQuantity FROM Orders WHERE OrderName = @OrderName";

                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@OrderName", ItemNameDetails);

                                    using (SqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            oldQuantity = Convert.ToInt32(reader["OrderQuantity"]);
                                            Console.WriteLine("Order Quantity: " + oldQuantity);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Order not found.");
                                        }
                                    }
                                }

                                // Update existing product
                                string updateQuery = "UPDATE Orders SET  OrderPrice = @OrderPrice, OrderImage = @OrderImage, OrderQuantity = @OrderQuantity, OrderTotal = @OrderTotal  WHERE OrderName = '" + ItemNameDetails + "'";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@OrderPrice", ItemPriceDetails);
                                    updateCommand.Parameters.AddWithValue("@OrderImage", imageBytes);
                                    updateCommand.Parameters.AddWithValue("@OrderQuantity", quantity += oldQuantity);
                                    updateCommand.Parameters.AddWithValue("@OrderTotal", ItemPriceDetails * quantity);
                                    updateCommand.ExecuteNonQuery();

                                    oldQuantity = quantity;
                                }
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                // Create an OrderDetailsControl with the selected details
                var orderDetailsControl = new OrderDetailsControl
                {
                    //rderImage = ItemImage,
                    ItemName = ItemNameDetails,
                    //Price = ItemPriceDetails,
                    //Quantity = quantity
                };
                orderDetailsControl.UpdateTotalPrice();

                // Invoke the callback to pass the order to the main form
                onOrder?.Invoke(orderDetailsControl);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a quantity greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void itemDescription_Click(object sender, EventArgs e)
        {

        }

        private void listIngredients_Click(object sender, EventArgs e)
        {

        }

        private void itemName_Click(object sender, EventArgs e)
        {

        }
    }
}
