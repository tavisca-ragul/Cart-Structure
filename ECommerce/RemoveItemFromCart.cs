using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    class RemoveItemFromCart : IRemove
    {
        public bool Remove(int itemID, int cartID)
        {
            return true;
        }
    }
}