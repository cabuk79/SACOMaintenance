using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.BuisnessModels
{
    public class PPE
    {
        public int Id { get; set; }
        public string PPEName { get; set; }
        public string Description { get; set; }
        //this is the request type so if it is plant then it is plant or if both then both
        //TODO: make this enum so that it can pull the information - PLANT, GENERAL, BOTH
        public string MaintRequestType { get; set; } 
        public List<MaintRequestInitiation> MaintRequestInitiations { get; set; } = new List<MaintRequestInitiation>();
    }
}
