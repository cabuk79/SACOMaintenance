using ExcelLibs;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WordLibs;

namespace SACOMaintenance.ViewModel
{
    public class MaintRequestFullViewModel : INotifyPropertyChanged, IMaintRequestFullViewModel
    {
        public MaintRequestInitiation maintReqInitation { get; set; } = new();
        public ObservableCollection<MaintRequestInitiationRisk> RiskInfoList { get; set; } = new();
        public ObservableCollection<Factory> FactoriesList { get; set; } = new();
        public ObservableCollection<Isolation> Isolations { get; set; } = new();
        public ObservableCollection<User> Users { get; set; } = new();
        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public List<string> SelectedIsolationIds { get; set; } = new List<string>();
        public IRisk RiskDataProvider { get; }
        public IFactory FactoryDataProvider { get; }
        public IPPE PpeDataProvider { get; }
        public IIsolations IsolationsDataProvider { get; }
        public IIsolationMaintRequestInitiation IsolationMaintReqDataProvider { get; }
        public IUsers UsersDataProvider { get; set; }
        public List<Isolation> IsolationsSelected { get; set; } = new();



        public MaintRequestFullViewModel(IMaintRequestInitiation maintReqInitProvider, IRisk riskDataProvider,
            IFactory factoryDataProvider, IPPE ppeDataProvider, 
            IIsolations isolationDataProvider, 
            IIsolationMaintRequestInitiation isolationMaintReqDataProvider,
            IUsers usersDataProvider)
        {
            MaintReqDataProvider = maintReqInitProvider;
            RiskDataProvider = riskDataProvider;
            FactoryDataProvider = factoryDataProvider;
            PpeDataProvider = ppeDataProvider;
            IsolationsDataProvider = isolationDataProvider;
            IsolationMaintReqDataProvider = isolationMaintReqDataProvider;
            UsersDataProvider = usersDataProvider;

            SelectedIsolationIds.Clear();
        }

        public int maintReqId
        {
            get => maintReqInitation.Id;
            set
            {
                if(maintReqInitation.Id != value)
                {
                    maintReqInitation.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string maintReqDetails
        {
            get => maintReqInitation.RequestDetails;
            set
            {
                if(maintReqInitation.RequestDetails != value)
                {
                    maintReqInitation.RequestDetails = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public int? maintReqAreaId
        {
            get => maintReqInitation.AreaId;
            set
            {
                if(maintReqInitation.AreaId != value)
                {
                    maintReqInitation.Area.Id = (int)value;
                    RaisePropertychangedEvent();
                }
            }
        }


        public int maintReqFactoryId
        {
            get => (int)maintReqInitation.FactoryId;
            set
            {
                if (maintReqInitation.FactoryId != value)
                {
                    maintReqInitation.Factory.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string areaName
        {
            get => maintReqInitation.Area.AreaName;
        }

        public string factoryName
        {
            get => maintReqInitation.Factory.FactoryName;
        }

        public string equipName
        {
            get => maintReqInitation.Equipment.Name;
        }

        public ObservableCollection<Risk> Risks { get; set; }
        public ObservableCollection<PPE> Ppe { get; set; } = new();
        public ObservableCollection<Isolation> IsolationByRequest { get; set; } = new();
        public List<int> AllIsolationIds { get; set; } = new();

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MaintRequestInitiation GetMaintReqInitation(int maintReqId)
        {
            maintReqInitation = MaintReqDataProvider.GetSingleRequestInitiation(maintReqId);
            return maintReqInitation;
        }

        //public async Task<MaintRequestInitiation> GetMaintReqInitation(int maintReqId)
        //{
        //    maintReqInitation = await MaintReqDataProvider.GetSingleRequestInitiation(maintReqId);
        //    return maintReqInitation;
        //}

        public async Task<bool> LoadMaintRiskData(int maintReqId)
        {
           RiskInfoList = new ObservableCollection<MaintRequestInitiationRisk>(await MaintReqDataProvider.LoadMaintRiskData(maintReqId));
            // RiskInfoList = MaintReqDataProvider.LoadMaintRiskData(main tReqId);
            //return RiskInfoList;

            return true;
        }

        public async Task<ObservableCollection<Factory>> LoadFactories()
        {
            FactoriesList = new ObservableCollection<Factory>(await FactoryDataProvider.LoadAllFactories());
            return FactoriesList;
        }

        public async void LoadAllUsers()
        {
            Users = new ObservableCollection<User>(await UsersDataProvider.GetAllUsers());
        }

        public async Task<ObservableCollection<Risk>> LoadRisks()
        {
            Risks = new ObservableCollection<Risk>(await RiskDataProvider.LoadallRisks());
            return Risks;
        }

        public void ExportRequest()
        {
            //MaintenanceRequestsExcel exportReqList = new MaintenanceRequestsExcel();
            //exportReqList.ExportSingalReqest(maintReqInitation, RiskInfoList);
            MaintenanceRequestWordExport WordExport = new MaintenanceRequestWordExport();
            WordExport.CreateMaintenanceRequestReport(maintReqInitation);
        }

        public async void LoadPPE()
        {
            var list = new ObservableCollection<PPE>(await PpeDataProvider.LoadAllPPE());
            Ppe.Clear();

            foreach(var item in list)
            {
                Ppe.Add(item);
            }
        }

        public async Task<ObservableCollection<Isolation>> LoadIsolations()
        {
            //Isolations = new ObservableCollection<Isolation>(await IsolationsDataProvider .LoadAllIsolations());
            
            var list = new ObservableCollection<Isolation>(await IsolationsDataProvider.LoadAllIsolations());

            foreach(var item in list)
            {
                Isolations.Add(item);
            }

            return Isolations;
        }

        public async Task<ObservableCollection<Isolation>> LoadIsoaltionsByMaint()
        {
            AllIsolationIds.Clear();

            AllIsolationIds = await IsolationMaintReqDataProvider.LoadAllIsolationsIds();

            SelectedIsolationIds.Clear();

            var isoList = new ObservableCollection<Isolation>(await IsolationMaintReqDataProvider.LoadIsolationsByMaint(maintReqId));
            
            foreach(var item in isoList)
            {
                IsolationByRequest.Add(item);
            }

            foreach(var item in IsolationByRequest)
            {
                if(item.MaintRequestInitiations.Count > 0)
                {
                    SelectedIsolationIds.Add(item.Id.ToString());
                }                                               
            }

            //IsolationsSelected  = IsolationByRequest.Where(i => i.MaintRequestInitiations.Count == 1).ToList();
            ObservableCollection<Isolation> TempList = new ObservableCollection<Isolation>();

            return TempList;
            //return IsolationByRequest;
        }

        public void UpdateMaintReqRisks()
        {
            // RiskInfoList
            MaintReqDataProvider.UpdateRiskRecords(RiskInfoList);
            MaintReqDataProvider.UpdateIsolationsRecords(SelectedIsolationIds, maintReqId, AllIsolationIds);
        }


        /// <summary>
        /// Update the maintenance request with all of the details
        /// </summary>
        public void UpdateRequest()
        {
           // MaintReqDataProvider
        }

 
    }
}
