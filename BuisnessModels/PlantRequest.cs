using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.BuisnessModels
{
    public class PlantRequest
    {
        public int IsolationNitricAcid { get; set; }
        public int IsolatedPhosphoricAcid { get; set; }
        public int IsolatedSodiumHydroxide { get; set; }
        public int IsolatedSulphuricAcid { get; set; }
        public string IsolatedOther { get; set; }


        public int DrainingLinesNitricAcid { get; set; }
        public int DrainingLinesPhosphoricAcid { get; set; }
        public int DrainingLinesSodiumHydroxide { get; set; }
        public int DrainingLinesSulphuricAcid { get; set; }
        public string DrainingLinesOther { get; set; }

        public int IsolationsCompressedAir { get; set; }
        public int IsolationsElectrical { get; set; }
        public int IsolationsGas { get; set; }
        public int IsolationsMechanical { get; set; }
        public int IsolationsSteam { get; set; }
        public int IsolationsWater { get; set; }
        public string IsolationsOther { get; set; }

        public string OtherPrecautions { get; set; }

        public int AuthorisationToWorkUserId { get; set; }
        public DateTime AuthorisationDatTime { get; set; }

        public int ReceiptPersonDoingWorkUserId { get; set; }
        public int ReceiptCompanyId { get; set; }
        public string ReceiptCompany { get; set; }
        public DateTime ReceiptDateTime { get; set; }


        public string ClearanceDetails { get; set; }
        public int ClearanceCompanyId { get; set; }
        public string ClearancePosition { get; set; }
        public DateTime ClearanceDateTime { get; set; }

        public List<RequestDailyRegister> ListOfDailyRgisters = new List<RequestDailyRegister>(); //List of all the daily registers linked to the request
    }
}










