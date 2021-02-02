using System;

namespace SACOMaintenance.BuisnessModels
{
    public class MaintRequestInitiation
    {
        public Guid Id { get; set; }
        public DateTime DateRaised { get; set; }
        public int CompanyId { get; set; } //FK to company table
        public int FactoryId { get; set; } //FK to factory table
        public int AreaId { get; set; } //FK to area table
        public int EquipmentId { get; set; } //FK to equipment table
        public int RequestedById { get; set; } //FK to users table
        public string RequestDetails { get; set; }
        public int RequestTypeId { get; set; } //FK to type table
    }
}
