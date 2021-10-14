using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System;

namespace SACOMaintenance.ViewModel
{
    public class AddMaintReqViewModel : INotifyPropertyChanged, IAddMaintReq
    {
        #region Properties

        public ObservableCollection<Priority> Priorities { get; set; } = new();
        //public ObservableCollection<Factory> Factories { get; set; } = new();
        //public ObservableCollection<AreaModel> Areas { get; set; }
        //public ObservableCollection<Equipment> Equipments { get; set; } = new();
        //public ObservableCollection<Company> Companies { get; set; } = new();

        //public MaintRequestInitiation MaintReq { get; set; }


        public IPriorities PriorityDataProvider { get; }
        //private IFactory FactoryDataProvider { get; }
        //private IArea AreaDataProvider { get; }
        //private IEquipment EquipmentDataProvider { get; }
        //private ICompany CompanyDataProvider { get; }

        #endregion


        #region Fields

        //public int NewAddedMaintId { get; set; }

        //public int CompanyId
        //{
        //    get => MaintReq.CompanyId;
        //    set
        //    {
        //        if (MaintReq.CompanyId != value)
        //        {
        //            MaintReq.CompanyId = value;
        //            RaisePropertychangedEvent();
        //        }
        //    }
        //}

        //public int FactoryId
        //{
        //    get => MaintReq.FactoryId;
        //    set
        //    {
        //        if (MaintReq.FactoryId != value)
        //        {
        //            MaintReq.FactoryId = value;                    
        //            RaisePropertychangedEvent();
        //            LoadAreasByFactory();
        //        }
        //    }
        //}


        //public int AreaId
        //{
        //    get => MaintReq.AreaId;
        //    set
        //    {
        //        if (MaintReq.AreaId != value)
        //        {
        //            MaintReq.AreaId = value;
        //            if (AreaId == 1)
        //            {
        //                MaintReq.RequestTypeId = 1;
        //            }
        //            else
        //            {
        //                MaintReq.RequestTypeId = 0;
        //            }
        //            RaisePropertychangedEvent();
        //            LoadEquipmentByArea();
        //        }
        //    }
        //}

        //public int EquipmentId
        //{
        //    get => MaintReq.EquipmentId;
        //    set
        //    {
        //        if (MaintReq.EquipmentId != value)
        //        {
        //            MaintReq.EquipmentId = value;
        //            RaisePropertychangedEvent();
        //        }
        //    }
        //}


        //public int PriorityId
        //{
        //    get => MaintReq.PriorityId;
        //    set
        //    {
        //        if (MaintReq.PriorityId != value)
        //        {
        //            MaintReq.PriorityId = value;
        //            RaisePropertychangedEvent();
        //        }
        //    }
        //}


        #endregion


        #region Methods

        public AddMaintReqViewModel(IPriorities priorityProvider)
            
        
        //, IFactory factoryDataProvider, IArea areaDataProvider,
        //    IEquipment equipmentDataProvider, ICompany companyDataProvider)
        {
            PriorityDataProvider = priorityProvider;
            //FactoryDataProvider = factoryDataProvider;
            //AreaDataProvider = areaDataProvider;
            //EquipmentDataProvider = equipmentDataProvider;
            //CompanyDataProvider = companyDataProvider;

            //MaintReq = new MaintRequestInitiation();

            LoadPriorities();
        }

        //public async Task<ObservableCollection<Priority>> LoadPriorities()
        public async void LoadPriorities()
        {
            Priorities = new ObservableCollection<Priority>(await PriorityDataProvider.LoadAllPriorities());
            //var prios = await PriorityDataProvider.LoadAllPriorities();
            //foreach(var item in prios)
            //{
            //    Priorities.Add(item);
            //}
            //return Priorities;
        }

        //public async Task<ObservableCollection<Company>> LoadCompanies()
        //{
        //    Companies = new ObservableCollection<Company>(await CompanyDataProvider.LoadCompanies());
        //    return Companies;
        //}

        //public async Task<ObservableCollection<Factory>> LoadFactories()
        //{
        //    Factories = new ObservableCollection<Factory>(await FactoryDataProvider.LoadAllFactories());
        //    return Factories;
        //}

        //public async void LoadAreasByFactory()// Task<ObservableCollection<AreaModel>> LoadAreasByFactory()
        //{               
        //    Areas = new ObservableCollection<AreaModel>(await AreaDataProvider.LoadAreasByFactory(MaintReq.FactoryId));
        //}

        //public async Task<ObservableCollection<Equipment>> LoadEquipmentByArea()
        //{
        //    Equipments = new ObservableCollection<Equipment>(await EquipmentDataProvider.LoadByArea(AreaId));
        //    return Equipments;
        //}

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
