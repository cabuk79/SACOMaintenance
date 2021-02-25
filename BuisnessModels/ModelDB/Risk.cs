using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class Risk
    {
        public int Id { get; set; }
        public string RiskName { get; set; }
        public string Description { get; set; }
        //this is the request type so if it is plant then it is plant or if both then both
        //TODO: make this enum so that it can pull the information - PLANT, GENERAL, BOTH
        public string MaintRequestType { get; set; }
        public List<MaintRequestInitiation> MaintRequestInitiation { get; set; } = new List<MaintRequestInitiation>();
    }
}
