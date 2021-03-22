using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IMaintRequestInitiation
    {
        IEnumerable<MaintRequestInitiation> LoadAllRequestInitations();
        MaintRequestInitiation GetSingleRequestInitiation(int Id);
        void AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation);
        IEnumerable<MaintRequestInitiation> LoadRequestInitiationWithEquipment();
        ObservableCollection<MaintRequestInitiationRisk> LoadMaintRiskData(int maintReqId);
        
    }
}
