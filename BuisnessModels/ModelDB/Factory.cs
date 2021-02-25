using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class Factory
    {
        public int Id { get; set; }
        public string FactoryName { get; set; }
        public List<MaintRequestInitiation> MaintRequestInitiations { get; set; } = new List<MaintRequestInitiation>();
        public List<AreaModel> Areas { get; set; } = new List<AreaModel>();
    }
}
