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

        public IEnumerable<AreaModel> Areas { get; set; }
        public IEnumerable<Factory> Factories { get; }
        public IEnumerable<Equipment> Equipment { get; }

        public MaintRequestInitiation MaintReq { get; set; }
        public int FactoryId { get; set; }
        #endregion

        #region methods

        public void AddNewRequest(MaintRequestInitiation maintReqToAdd);
        public void LoadAreasByFactory();
        #endregion
    }
}
