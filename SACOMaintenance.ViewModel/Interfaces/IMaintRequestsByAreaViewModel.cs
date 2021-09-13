using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IMaintRequestsByAreaViewModel
    {
        public IMaintRequestInitiation MinatReqDataProvider { get; }
        public IEnumerable<MaintRequestInitiation> MaintReqs { get; set; }
        public void GetRequestsByArea();
    }
}
