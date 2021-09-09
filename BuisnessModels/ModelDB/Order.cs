using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class Order
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int DepartmentId { get; set; }
        public Department Departme { get; set; }
        public string Comments { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
