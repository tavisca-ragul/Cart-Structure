using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    interface IPurchase
    {
        void CheckOut(int id, string PaymentMethod);
    }
}