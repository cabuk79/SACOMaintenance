using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IRequestsGraphViewModel
    {
        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public ObservableCollection<MaintRequestInitiation> MaintReqs { get; set; }

        public int GetRequestsByStatusCount(int statusId);
    }
}
