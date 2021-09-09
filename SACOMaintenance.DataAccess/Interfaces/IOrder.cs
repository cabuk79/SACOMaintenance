﻿using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IOrder
    {
        IEnumerable<Order> LoadAllOrders();
        Order LoadSingleOrder(int Id);
    }
}
