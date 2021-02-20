using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.BuisnessModels
{
    public class Company
    {
        public int Id { get; set; }
        public string CompantName { get; set; }
        public List<MaintRequestInitiation> MaintenanceRequestIniations { get; set; } = new List<MaintRequestInitiation>();
    }
}
