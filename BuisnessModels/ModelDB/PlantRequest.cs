using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    //TODO: need to review the property types
    public class PlantRequest
    {
        public int Id { get; set; }
        public bool IsolationNitricAcid { get; set; }
        public bool IsolatedPhosphoricAcid { get; set; }
        public bool IsolatedSodiumHydroxide { get; set; }
        public bool IsolatedSulphuricAcid { get; set; }
        public string IsolatedOther { get; set; }


        public bool DrainingLinesNitricAcid { get; set; }
        public bool DrainingLinesPhosphoricAcid { get; set; }
        public bool DrainingLinesSodiumHydroxide { get; set; }
        public bool DrainingLinesSulphuricAcid { get; set; }
        public string DrainingLinesOther { get; set; }


        public bool IsolationsCompressedAir { get; set; }
        public bool IsolationsElectrical { get; set; }
        public bool IsolationsGas { get; set; }
        public bool IsolationsMechanical { get; set; }
        public bool IsolationsSteam { get; set; }
        public bool IsolationsWater { get; set; }
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

        public List<RequestDailyRegister> ListOfDailyRgisters = new(); //List of all the daily registers linked to the request

        public int MaintRequestId { get; set; } //FK to the maintenance request initation table
        public virtual MaintRequestInitiation MaintRequestInitiation { get; set; }
    }
}










