using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    interface IAdd
    {
        bool Add(Item item, int cartID);
    }
}