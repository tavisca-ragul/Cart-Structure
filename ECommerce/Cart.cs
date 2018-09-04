using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    class Cart
    {
        public int CartID { get; set; }
        public List<Item> Items { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
    }
}