﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    interface IRemove
    {
        bool Remove(int itemID, int cartID);
    }
}