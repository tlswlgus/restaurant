using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    internal class Order
    {
        public string OrderName { get; set; }
        public int OrderQuantity { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
