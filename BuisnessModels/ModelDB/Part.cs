using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public int MinQtyInStock { get; set; }
        public int CurrentQty { get; set; }
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();
        public List<PartSupplier> SupplierParts { get; set; } = new List<PartSupplier>();
    }
}
