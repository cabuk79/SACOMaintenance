using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SACOMaintenance.DataAccess.Interfaces;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IPPEViewModel
    {
        #region properties

        public PPE ppe { get; set; }
        IPPE PPEDataProvider { get; }
        public int Id { get; set; }
        public string PPEName { get; set; }
        public string IconLocation { get; set; }
        public ObservableCollection<PPE> PPEList { get; set; }

        #endregion

        #region methods

        void LoadAllPPE();

        #endregion
    }
}
