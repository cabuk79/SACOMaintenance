using SACOMaintenance.Common.ModelDB;
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

        public IEnumerable<Order> LoadAllOrders()
        {
            var orders = _sacoMaintenanceContext.Orders
                .Include(oi => oi.OrderItems)
                .ToList();
            return orders;
        }

        public Order LoadSingleOrder(int Id)
        {
            var order = _sacoMaintenanceContext.Orders.FirstOrDefault(o => o.Id == Id);
            return order;
        }
    }
}
 