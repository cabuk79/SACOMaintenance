using ExcelLibs;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WordLibs;

namespace SACOMaintenance.ViewModel
{
    public class MaintRequestFullViewModel : INotifyPropertyChanged, IMaintRequestFullViewModel
    {
        public MaintRequestInitiation maintReqInitation { get; set; } = new();
        public ObservableCollection<MaintRequestInitiationRisk> RiskInfoList { get; set; } = new();
        public ObservableCollection<Factory> FactoriesList { get; set; } = new();
        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public IRisk RiskDataProvider { get; }
        public IFactory FactoryDataProvider { get; }

        public MaintRequestFullViewModel(IMaintRequestInitiation maintReqInitProvider, IRisk riskDataProvider, IFactory factoryDataProvider)
        {
            MaintReqDataProvider = maintReqInitProvider;
            RiskDataProvider = riskDataProvider;
            FactoryDataProvider = factoryDataProvider;
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
        

        
        

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        MaintRequestInitiation IMaintRequestFullViewModel.GetMaintReqInitation(int maintReqId)
        {
            maintReqInitation = MaintReqDataProvider.GetSingleRequestInitiation(maintReqId);
            return maintReqInitation;
        }

        public void LoadMaintRiskData(int maintReqId)
        {
            RiskInfoList = new ObservableCollection<MaintRequestInitiationRisk>(MaintReqDataProvider.LoadMaintRiskData(maintReqId));
            // RiskInfoList = MaintReqDataProvider.LoadMaintRiskData(main tReqId);
            //return RiskInfoList;
        }

        public ObservableCollection<Factory> LoadFactories()
        {
            FactoriesList = new ObservableCollection<Factory>(FactoryDataProvider.LoadAllFactories());
            return FactoriesList;
        }

        public void LoadRisks()
        {
            Risks = new ObservableCollection<Risk>(RiskDataProvider.LoadallRisks());
        }

        public void ExportRequest()
        {
            //MaintenanceRequestsExcel exportReqList = new MaintenanceRequestsExcel();
            //exportReqList.ExportSingalReqest(maintReqInitation, RiskInfoList);
            MaintenanceRequestWordExport WordExport = new MaintenanceRequestWordExport();
            WordExport.CreateMaintenanceRequestReport(maintReqInitation);
        }
    }
}
