using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class PostCodeTown
    {
        public int Id { get; set; }
        public string PostCode { get; set; }
        public string County { get; set; }
        public string District { get; set; }
        public decimal Latitide { get; set; }
        public decimal Longitude { get; set; }
    }
}
