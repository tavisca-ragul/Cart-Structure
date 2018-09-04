using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    class AddItemToCart : IAdd
    {
        public bool Add(Item item, int cartID)
        {
            return true;
        }
    }
}