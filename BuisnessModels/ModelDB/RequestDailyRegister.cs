using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class RequestDailyRegister
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimOut { get; set; }
        public int PlantMaintRequestId { get; set; } //FK to the MaintRequestInitiation ID
        public virtual PlantRequest PlantRequest { get; set; }
       
    }
}
