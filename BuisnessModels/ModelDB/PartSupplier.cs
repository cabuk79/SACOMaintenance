using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class PartSupplier
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
        public string SupplierCode { get; set; }
        public decimal Price { get; set; }
        public int SupplierId { get; set; }
        //public Supplier Supplier { get; set; }
        public Supplier PartSupplierSingle { get; set; } // = new Supplier();
    }
}
