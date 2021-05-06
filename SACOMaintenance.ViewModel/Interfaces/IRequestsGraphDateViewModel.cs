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
    public interface IRequestsGraphDateViewModel
    {
        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public IEnumerable<MaintRequestInitiation> MaintReqs { get; set; }

        public void GetRequests();
    }
}
