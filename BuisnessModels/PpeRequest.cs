using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.BuisnessModels
{
    public class PpeRequest
    {
        public int PPDId { get; set; } //FK to PPE table
        public int MaintReqInitiationId { get; set; } //FK to MaintRequestInitation
    }
}
