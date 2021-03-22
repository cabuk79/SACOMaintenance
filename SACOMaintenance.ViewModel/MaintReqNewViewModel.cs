using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;

namespace SACOMaintenance.ViewModel
{
    public class MaintReqNewViewModel : INotifyPropertyChanged, IMaintReqNewViewModel
    {
        public IMaintRequestInitiation MaintReqDataProvider { get; }

        public IFactory FactoryDataProvider { get; }

        public IEquipment EquipmentDataProvider { get; }

        public IArea AreaDataProvider { get; }

        public MaintRequestInitiation MaintReq { get; set; }
       
        public IEnumerable<AreaModel> Areas { get; set; }

        public IEnumerable<Factory> Factories { get; }

        public IEnumerable<Equipment> Equipment { get; }
        public int FactoryId
        {
            get => MaintReq.FactoryId.GetValueOrDefault();
            set
            {
                if(MaintReq.FactoryId != value)
                {
                    MaintReq.FactoryId = value;
                    RaisePropertychangedEvent();
                    LoadAreasByFactory();
                }
            }
        }
        

        public MaintReqNewViewModel(IMaintRequestInitiation maintReqDataProvider, IFactory factoryDataProvider, IEquipment equipmentProvider, IArea areaProvider)
        {
            FactoryDataProvider = factoryDataProvider;
            EquipmentDataProvider = equipmentProvider;
            AreaDataProvider = areaProvider;
            MaintReqDataProvider = maintReqDataProvider;

           // Areas = AreaDataProvider.LoadAllAreas();
            Factories = FactoryDataProvider.LoadAllFactories();
            Equipment = EquipmentDataProvider.LoadAllEquipments();

            MaintReq = new MaintRequestInitiation();
        }

        public void AddNewRequest(MaintRequestInitiation maintReqToAdd)
        {
            MaintReqDataProvider.AddEditRequestInitiation(MaintReq);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void LoadAreasByFactory()
        {
            Areas = AreaDataProvider.LoadAreasByFactory(MaintReq.FactoryId.Value);
        }
    }
}
