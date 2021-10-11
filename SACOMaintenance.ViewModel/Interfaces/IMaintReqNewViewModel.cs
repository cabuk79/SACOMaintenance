using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IMaintReqNewViewModel
    {
        #region properties

        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public IFactory FactoryDataProvider { get; }
        public IEquipment EquipmentDataProvider { get; }
        public IArea AreaDataProvider { get; }
        public IPriorities PriorityDataProvider { get; }
        

        public ObservableCollection<AreaModel> Areas { get; set; }
        public ObservableCollection<Factory> Factories { get; }
        public ObservableCollection<Equipment> Equipment { get; set; }
        public ObservableCollection<Priority> Priorities { get; set; }
        public ObservableCollection<Company> Companies { get; set; }
        

        public MaintRequestInitiation MaintReq { get; set; }
        public int FactoryId { get; set; }
        public int AreaId { get; set; }
        public int EquipmentId { get; set; }
        public int PriorityId { get; set; }
        public int CompanyId { get; set; }
        public int NewAddedMaintId { get; set; }
        public bool SendTextMessageForEmergencyPriority { get; set; }
        #endregion


        #region methods

        public void AddNewRequest();
        public void LoadAreasByFactory();
        public void LoadPriorities();
        
        #endregion
    }
}
