using System;
using System.Collections.Generic;

namespace SACOMaintenance.Common.ModelDB
{
    public class MaintRequestInitiation
    {
        public int Id { get; set; }
        public DateTime DateRaised { get; set; }
        public int? CompanyId { get; set; } //FK to company table
        public Company Company { get; set; }
        public virtual int? FactoryId { get; set; } //FK to factory table
        public Factory Factory { get; set; }
        public virtual int? AreaId { get; set; } //FK to area table
        public AreaModel Area { get; set; }
        public int? EquipmentId { get; set; } //FK to equipment table
        public Equipment Equipment { get; set; }
        public int RequestedById { get; set; } //FK to users table
        public string RequestDetails { get; set; }
        public int? PriorityId { get; set; } //FK to priority table
        public Priority Priority { get; set; }
        public int RequestTypeId { get; set; } //FK to type table
        //public List<MaintRequestInitiationRisk> MaintRequestInitiationRisk { get; set; } = new List<MaintRequestInitiationRisk>();
        public List<Risk> Risks { get; set; } = new List<Risk>();
        public List<PPE> PPEEquipment { get; set; } = new List<PPE>();
        public List<User> Users { get; set; } = new List<User>();
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int AssignedTo { get; set; }  //TODO: check if there needs to be multiple people assigned as well as single
    }
}
