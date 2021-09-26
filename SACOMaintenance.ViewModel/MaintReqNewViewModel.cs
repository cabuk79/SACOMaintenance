using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EmployeeManager.ViewModel.Command;
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

        public IPriorities PriorityDataProvider { get; }
        public ICompany CompanyDataProvider { get; }

        public MaintRequestInitiation MaintReq { get; set; }

        public IEnumerable<AreaModel> Areas { get; set; }


        public IEnumerable<Factory> Factories { get; }
        public DelegateCommand SaveCommand { get; } //Delehgate command is for MVVM for desktop GUI's
        public IEnumerable<Equipment> Equipment { get; set; }
        public IEnumerable<Priority> Priorities { get; set; }
        public IEnumerable<Company> Companies { get; set; }

        public int FactoryId
        {
            get => MaintReq.FactoryId;
            set
            {
                if (MaintReq.FactoryId != value)
                {
                    MaintReq.FactoryId = value;
                    RaisePropertychangedEvent();
                    LoadAreasByFactory();
                }
            }
        }

        public int CompanyId 
        {
            get => MaintReq.CompanyId;
            set
            {
                if(MaintReq.CompanyId != value)
                {
                    MaintReq.CompanyId = value;
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
                    if (AreaId == 31)
                    {
                        MaintReq.RequestTypeId = 1;
                    }
                    else
                    {
                        MaintReq.RequestTypeId = 0;
                    }
                    RaisePropertychangedEvent();
                    LoadEquipmentByArea();
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


        public MaintReqNewViewModel(IMaintRequestInitiation maintReqDataProvider,
            IFactory factoryDataProvider, IEquipment equipmentProvider, IArea areaProvider,
            IPriorities priorityProvider, ICompany companyProvider)
        {
            FactoryDataProvider = factoryDataProvider;
            EquipmentDataProvider = equipmentProvider;
            AreaDataProvider = areaProvider;
            MaintReqDataProvider = maintReqDataProvider;
            PriorityDataProvider = priorityProvider;
            CompanyDataProvider = companyProvider;

            // Areas = AreaDataProvider.LoadAllAreas();
            Factories = FactoryDataProvider.LoadAllFactories();
            //Equipment = EquipmentDataProvider.LoadAllEquipments();
            LoadPriorities();
            LoadCompanies();

            SaveCommand = new DelegateCommand(AddNewRequest);

            MaintReq = new MaintRequestInitiation();
        }

        public void AddNewRequest()
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
            Areas = AreaDataProvider.LoadAreasByFactory(MaintReq.FactoryId);
        }

        private void LoadEquipmentByArea()
        {
            Equipment = EquipmentDataProvider.LoadByArea(MaintReq.AreaId);
        }

        public void LoadCompanies()
        {
            Companies = CompanyDataProvider.LoadCompanies();
        }

        public void LoadPriorities()
        {
            Priorities = PriorityDataProvider.LoadAllPriorities();
        }
    }
}
