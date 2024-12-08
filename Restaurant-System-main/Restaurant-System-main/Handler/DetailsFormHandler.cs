using RestaurantSystem.Data;
using RestaurantSystem.UI;
using RestaurantSystem.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;
using MenuItem = RestaurantSystem.Models.MenuItem;


namespace RestaurantSystem.Handler
{
    internal class DetailsFormHandler
    {
        private readonly DatabaseHandler _menuDetailsRepository;
        private readonly MenuDetailsForm _menuDetailsForm;

        public DetailsFormHandler(MenuDetailsForm menuDetailsForm, DatabaseHandler databaseHandler)
        {
            _menuDetailsForm = menuDetailsForm;
            _menuDetailsRepository = databaseHandler;
        }

        public void LoadMenuDetails(MenuItem item)
        {
            // Populate the details form with item data
            _menuDetailsForm.ItemNameDetails = item.Name;
            _menuDetailsForm.ItemDescriptionDetails = item.LongDescription;
            _menuDetailsForm.ItemPriceDetails = item.Price;
            _menuDetailsForm.ItemListIngredientsDetails = item.ListIngredients;
            _menuDetailsForm.ItemImage = ImageHelper.ByteArrayToImage(item.Image);

        }
    }
}