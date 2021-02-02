using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.BuisnessModels
{
    public class RiskRequest
    {
        public int RiskAssementId { get; set; } //FK to RiskRequest ID
        public int MaintReqInitiation { get; set; } //FK to MaintRequestInitiation
    }
}
