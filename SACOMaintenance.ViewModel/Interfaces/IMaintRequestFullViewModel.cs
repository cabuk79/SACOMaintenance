using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IMaintRequestFullViewModel
    {
        #region properties

        MaintRequestInitiation maintReqInitation { get; set; }
        ObservableCollection<MaintRequestInitiationRisk> RiskInfoList { get; set; }
        ObservableCollection<Factory> FactoriesList { get; set; }
        ObservableCollection<Risk> Risks { get; set; }
        ObservableCollection<PPE> Ppe { get; set; }
        ObservableCollection<Isolation> Isolations { get; set; }
        ObservableCollection<Isolation> IsolationByRequest { get; set; }
        List<PPE> PPEItemsSelected { get; set; }
        List<string> SelectedIsolationIds { get; set; }
        public List<Isolation> IsolationsSelected { get; set; }
        public List<MaintRequestInitiationRisk> RiskListsChosen { get; set; }
        //List<PPE> PPEItemsSelected { get; set; }

        IMaintRequestInitiation MaintReqDataProvider { get; }
        IRisk RiskDataProvider { get; }       
        int maintReqId { get; set; }
        string maintReqDetails { get; set; }
        int? maintReqAreaId { get; set; }
        int maintReqFactoryId { get; set; }
        public string areaName { get; }
        public string factoryName { get; }
        public string equipName { get; }
        #endregion

        #region methods
        public MaintRequestInitiation GetMaintReqInitation(int maintReqId);
        //public Task<MaintRequestInitiation> GetMaintReqInitation(int maintReqId);
        //ObservableCollection<MaintRequestInitiationRisk> LoadRiskLevel(int maintReqId);
        Task<ObservableCollection<Factory>> LoadFactories();

        //public void LoadMaintRiskData(int maintReqId);
        public Task<bool> LoadMaintRiskData(int maintReqId);
        Task<ObservableCollection<Risk>> LoadRisks();
        void ExportRequest();
        public Task LoadPPE();
        Task<ObservableCollection<Isolation>> LoadIsolations();
        Task<ObservableCollection<Isolation>> LoadIsoaltionsByMaint();
        public void UpdateRequest();
        public void UpdateMaintReqRisks();
        

        #endregion
    }
}
