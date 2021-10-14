﻿using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class OrderDataProvider : IOrder
    {
        private readonly SACOMaintenanceContext _sacoMaintenanceContext;
        
        public OrderDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _sacoMaintenanceContext = sacoMaintenanceContext;
        }

        public async Task<IEnumerable<Order>> LoadAllOrders()
        {
            var orders = await _sacoMaintenanceContext.Orders
                .Include(oi => oi.OrderItems)
                .ToListAsync();
            return orders;
        }

        public async Task<Order> LoadSingleOrder(int Id)
        {
            var order = await _sacoMaintenanceContext.Orders.FirstOrDefaultAsync(o => o.Id == Id);
            return order;
        }
    }
}
 