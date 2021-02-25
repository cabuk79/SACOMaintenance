using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MachineTypeId { get; set; } //Fk to machine type table
        public string SerialIdentifierNumber { get; set; }
        public string Comments { get; set; }
        public int? AreaId { get; set; } //FK to the area table
        public AreaModel Area { get; set; }
        public List<MaintRequestInitiation> MaintRequestInitiations { get; set; } = new List<MaintRequestInitiation>();

    }
}
