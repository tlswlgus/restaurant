using System;
using System.Windows.Forms;

namespace RestaurantSystem.UI
{
    public partial class CategoryButtonControl : UserControl
    {
        public string btnText
        {
            get => btnCategory.Text;
            set => btnCategory.Text = value;
        }

        public string btnName
        {
            get => btnCategory.Name;
            set => btnCategory.Name = value;
        }

        public CategoryButtonControl()
        {
            InitializeComponent();
            
        }

        
    }
}
