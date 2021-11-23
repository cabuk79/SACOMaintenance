using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Comments { get; set; }
        public int Qty { get; set; } 
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int? PartId { get; set; }
        public virtual Part Part { get; set; }

        public decimal FullPrice
        {
            get
            {               
                return Qty * Price;
            }

        }

    }
}
