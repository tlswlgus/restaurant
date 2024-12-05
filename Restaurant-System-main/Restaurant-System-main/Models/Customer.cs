using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public bool IsPWD { get; set; }
        public bool IsSenior { get; set; }
    }

}
