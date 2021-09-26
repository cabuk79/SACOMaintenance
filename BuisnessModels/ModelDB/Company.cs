using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public List<MaintRequestInitiation> MaintenanceRequestIniations { get; set; } = new();
    }
}
