using System;
using System.Collections.Generic;

namespace SACOMaintenance.Common.ModelDB
{
    public class MaintRequestInitiation
    {
        public int Id { get; set; }
        public bool Closed { get; set; }
        public DateTime DateRaised { get; set; }
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int CompanyId { get; set; } //FK to company table        
        public virtual Company Company { get; set; }
        public virtual int FactoryId { get; set; } //FK to factory table
        public virtual Factory Factory { get; set; }
        public virtual int AreaId { get; set; } //FK to area table
        public virtual AreaModel Area { get; set; }
        public int EquipmentId { get; set; } //FK to equipment table
        public virtual Equipment Equipment { get; set; }
        public string UserId { get; set; } //FK to users table
        //public virtual User User { get; set; }
        public string RequestDetails { get; set; }
        public int PriorityId { get; set; } //FK to priority table
        public virtual Priority Priority { get; set; }
        public int RequestTypeId { get; set; } //FK to type table
        //public List<MaintRequestInitiationRisk> MaintRequestInitiationRisk { get; set; } = new List<MaintRequestInitiationRisk>();
        public List<Isolation> Isolations { get; set; } = new List<Isolation>();
        public List<Risk> Risks { get; set; } = new List<Risk>();
        public List<PPE> PPEEquipment { get; set; } = new List<PPE>();
        public List<User> Users { get; set; } = new List<User>(); //For maintenance staff assigned to the request
        public List<MaintReqUptateNote> UpdateNotes { get; set; } = new();
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        //public List<AuthorizationRequest> AuthorizationRequests { get; set; } = new();
        public int AssignedTo { get; set; }  //TODO: check if there needs to be multiple people assigned as well as single

        public string FullMaintCode
        {
            get
            {
                return "MAINT-" + String.Format("{0:D4}", Id);
            }

        }
    }
}
