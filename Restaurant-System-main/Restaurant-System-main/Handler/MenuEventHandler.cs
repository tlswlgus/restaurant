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

        public MenuEventHandler(DatabaseHandler menuItemRepository, FlowLayoutPanel menuPanel)
        {
            _menuItemRepository = menuItemRepository;
            _menuPanel = menuPanel;
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
                    var menuDetailsForm = new MenuDetailsForm();
                    var detailsFormHandler = new DetailsFormHandler(menuDetailsForm, _menuItemRepository);
                    detailsFormHandler.LoadMenuDetails(item);

                    menuDetailsForm.ShowDialog();
                };

                _menuPanel.Controls.Add(menuItemControl);
            }


        }

    }

}
