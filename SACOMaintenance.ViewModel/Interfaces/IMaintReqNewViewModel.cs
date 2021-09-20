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

        public IEnumerable<AreaModel> Areas { get; set; }
        public IEnumerable<Factory> Factories { get; }
        public IEnumerable<Equipment> Equipment { get; set; }
        public IEnumerable<Priority> Priorities { get; set; }
        public IEnumerable<Company> Companies { get; set; }

        public MaintRequestInitiation MaintReq { get; set; }
        public int FactoryId { get; set; }
        public int AreaId { get; set; }
        public int EquipmentId { get; set; }
        public int PriorityId { get; set; }
        public int CompanyId { get; set; }
        #endregion

        #region methods

        public void AddNewRequest();
        public void LoadAreasByFactory();
        public void LoadPriorities();
        #endregion
    }
}
