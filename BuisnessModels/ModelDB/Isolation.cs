using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class Isolation
    {
        public int Id { get; set; }
        public string Name { get; set; }     
        public string ImageLocation { get; set; }
        public List<MaintRequestInitiation> MaintRequestInitiations { get; set; } = new List<MaintRequestInitiation>();
    }
}
