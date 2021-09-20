using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
        MaintRequestInitiation GetMaintReqInitation(int maintReqId);
        //ObservableCollection<MaintRequestInitiationRisk> LoadRiskLevel(int maintReqId);
        ObservableCollection<Factory> LoadFactories();
        public void LoadMaintRiskData(int maintReqId);
        public void LoadRisks();
        void ExportRequest();
        public void LoadPPE();
        #endregion
    }
}
