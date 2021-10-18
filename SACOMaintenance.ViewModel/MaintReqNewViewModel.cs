using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EmployeeManager.ViewModel.Command;
using Microsoft.Extensions.Configuration;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;

namespace SACOMaintenance.ViewModel
{
    public class MaintReqNewViewModel : INotifyPropertyChanged, IMaintReqNewViewModel
    {
        #region Data Providers

        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public IFactory FactoryDataProvider { get; }
        public IEquipment EquipmentDataProvider { get; }
        public IArea AreaDataProvider { get; }
        public IPriorities PriorityDataProvider { get; }
        public ICompany CompanyDataProvider { get; }

        #endregion


        public MaintRequestInitiation MaintReq { get; set; }
        public ObservableCollection<AreaModel> Areas { get; set; } = new();
        public IEnumerable<Factory> Factories { get; set; }
        public ObservableCollection<Equipment> Equipment { get; set; } = new();
        public ObservableCollection<Priority> Priorities { get; set; } = new();
        public ObservableCollection<Company> Companies { get; set; } = new();

        public bool SendTextMessageForEmergencyPriority { get; set; }
        public DelegateCommand SaveCommand { get; } //Delehgate command is for MVVM for desktop GUI's
        public int NewAddedMaintId { get; set; }

        public int CompanyId
        {
            get => MaintReq.CompanyId;
            set
            {
                if (MaintReq.CompanyId != value)
                {
                    MaintReq.CompanyId = value;
                    RaisePropertychangedEvent();
                    //LoadFactoriesByCompany();
                }
            }
        }

        public int FactoryId
        {
            get => MaintReq.FactoryId;
            set
            {
                if (MaintReq.FactoryId != value)
                {
                    MaintReq.FactoryId = value;
                    RaisePropertychangedEvent();

                    //new Task(async() =>
                    //{
                    //    await LoadAreasByFactory();
                    //}).Start();
                    //await LoadAreasByFactory();
                }
            }
        }

        public int AreaId
        {
            get => MaintReq.AreaId;
            set
            {
                if (MaintReq.AreaId != value)
                {
                    MaintReq.AreaId = value;
                    if (AreaId == 1)
                    {
                        MaintReq.RequestTypeId = 1;
                    }
                    else
                    {
                        MaintReq.RequestTypeId = 0;
                    }
                    RaisePropertychangedEvent();
                    //LoadEquipmentByArea();
                }
            }
        }

        public int EquipmentId
        {
            get => MaintReq.EquipmentId;
            set
            {
                if (MaintReq.EquipmentId != value)
                {
                    MaintReq.EquipmentId = value;
                    RaisePropertychangedEvent();
                }
            }
        }


        public int PriorityId
        {
            get => MaintReq.PriorityId;
            set
            {
                if (MaintReq.PriorityId != value)
                {
                    MaintReq.PriorityId = value;
                    RaisePropertychangedEvent();
                }
            }
        }

       

        public IConfiguration _config;

        public MaintReqNewViewModel(IMaintRequestInitiation maintReqDataProvider,
            IFactory factoryDataProvider, IEquipment equipmentProvider, IArea areaProvider,
            IPriorities priorityProvider, ICompany companyProvider, IConfiguration config)
        {
            FactoryDataProvider = factoryDataProvider;
            EquipmentDataProvider = equipmentProvider;
            AreaDataProvider = areaProvider;
            MaintReqDataProvider = maintReqDataProvider;
            PriorityDataProvider = priorityProvider;
            CompanyDataProvider = companyProvider;

            // Areas = AreaDataProvider.LoadAllAreas();
            //Factories = FactoryDataProvider.LoadAllFactories();
            //Factories = new ObservableCollection<Factory>(FactoryDataProvider.LoadAllFactories());
            //Equipment = EquipmentDataProvider.LoadAllEquipments();

            //LoadFactories();
            
            LoadPriorities();
            LoadCompanies();

            SaveCommand = new DelegateCommand(AddNewRequest);

            MaintReq = new MaintRequestInitiation();

            _config = config;
            SendTextMessageForEmergencyPriority = Convert.ToBoolean(_config["SendTextMessageForEmergencyPriority"]);
        }

        public void AddNewRequest()
        {
            NewAddedMaintId =  MaintReqDataProvider.AddEditRequestInitiation(MaintReq);
            //NewAddedMaintId = MaintReq.Id;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public async Task LoadFactories()
        {
            Factories = await FactoryDataProvider.LoadAllFactories();
        }

        public async Task LoadFactoriesByCompany()
        {
            Factories = new ObservableCollection<Factory>(await FactoryDataProvider.LoadAllFactories());
        }

        public async Task LoadAreasByFactory()
        {
            Areas.Clear();
            Areas = new ObservableCollection<AreaModel>(await AreaDataProvider.LoadAreasByFactory(MaintReq.FactoryId)); //(MaintReq.FactoryId));
            //foreach(var item in list)
            //{
            //    Areas.Add(item);
            //}
        }

        public async Task LoadEquipmentByArea()
        {
            Equipment.Clear();
            Equipment = new ObservableCollection<Equipment>(await EquipmentDataProvider.LoadByArea(MaintReq.AreaId));
        }

        public async void LoadCompanies()
        {
            var comps = await CompanyDataProvider.LoadCompanies();
            foreach(var item in comps)
            {
                Companies.Add(item);
            }
        }

        public async void LoadPriorities()
        {
            var prios = await PriorityDataProvider.LoadAllPriorities();
            foreach(var item in prios)
            {
                Priorities.Add(item);
            }
            //return Priorities;
        }
    }
}
