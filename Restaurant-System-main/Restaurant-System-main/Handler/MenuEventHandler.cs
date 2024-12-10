using RestaurantSystem.Data;
using RestaurantSystem.UI;
using RestaurantSystem.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantSystem.Handler
{
    internal class MenuEventHandler
    {
        private readonly DatabaseHandler _menuItemRepository;
        private readonly FlowLayoutPanel _menuPanel;
        private readonly FlowLayoutPanel _orderListPanel; // Panel to display order details

        public MenuEventHandler(DatabaseHandler menuItemRepository, FlowLayoutPanel menuPanel, FlowLayoutPanel orderListPanel)
        {
            _menuItemRepository = menuItemRepository;
            _menuPanel = menuPanel;
            _orderListPanel = orderListPanel;
        }

        public void LoadMenuItems(string category = "All", string searchTerm = "")
        {
            // Fetch and filter menu items
            var menuItems = _menuItemRepository.GetMenuItems();

            // Filter by category
            if (category != "All")
            {
                menuItems = menuItems.Where(item => item.Category == category).ToList();
            }
            // Filter by search term if provided
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                menuItems = menuItems
                    .Where(item => item.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }

            // Clear the panel and insert with filtered items
            _menuPanel.Controls.Clear();
            foreach (var item in menuItems)
            {
                var menuItemControl = new MenuItemControl
                {
                    ItemName = item.Name,
                    ItemDescription = item.ShortDescription,
                    Price = item.Price,
                    ItemImage = ImageHelper.ByteArrayToImage(item.Image)
                };

                // Attach click event
                menuItemControl.Click += (sender, args) =>
                {
                    // Create and show the MenuDetailsForm with a callback
                    var menuDetailsForm = new MenuDetailsForm(orderDetailsControl =>
                    {
                        // Add order to the order list panel
                        AddOrderToPanel(orderDetailsControl);
                    })
                    {
                        ItemNameDetails = item.Name,
                        ItemPriceDetails = item.Price,
                        ItemDescriptionDetails = item.LongDescription,
                        ItemImage = ImageHelper.ByteArrayToImage(item.Image),
                        
                        //ItemListIngredientsDetails = item.Ingredients //  Property to add
                    };

                    menuDetailsForm.ShowDialog();
                };

                _menuPanel.Controls.Add(menuItemControl);
            }
        }

        private void AddOrderToPanel(OrderDetailsControl orderDetails)
        {
            // Check if the item already exists in the order list
            var existingOrder = _orderListPanel.Controls
                .OfType<OrderDetailsControl>()
                .FirstOrDefault(order => order.ItemName == orderDetails.ItemName);
                
            if (existingOrder != null)
            {
                // Update the quantity and total price
                existingOrder.Quantity += orderDetails.Quantity;
                existingOrder.UpdateTotalPrice(false);
            }
            else
            {
                // Add a new order control to the panel
                _orderListPanel.Controls.Add(orderDetails);
            }
        }
    }
}
