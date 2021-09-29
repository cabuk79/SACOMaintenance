using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IGeneralMaintRequestViewModel
    {
        ObservableCollection<PPE> ppeList { get; set; }
        public int maintId { get; set; }
        public GeneralRequest genralRequestInfo { get; set; }
        
        public void GetGeneralRequest(int maintId);
    }
}
