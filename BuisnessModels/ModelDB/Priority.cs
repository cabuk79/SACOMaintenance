using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Icon { get; set; }
        public List<MaintRequestInitiation> MaintRes { get; set; } = new();

    }   
}
