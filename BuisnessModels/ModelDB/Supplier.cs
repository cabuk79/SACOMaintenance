using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PartSupplier> SupplierParts { get; set; } = new List<PartSupplier>();
    }
}
