using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.BuisnessModels
{
    public class Status
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public List<MaintRequestInitiation> MaintRequestInitiations { get; set; } = new List<MaintRequestInitiation>();
    }
}
