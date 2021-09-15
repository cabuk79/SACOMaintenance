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
        public string GeneralEmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public string Comments { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public int? PostCodeId { get; set; }
        public PostCodeTown Postcode { get; set; }
        public List<PartSupplier> SupplierParts { get; set; } = new List<PartSupplier>();
    }
}
