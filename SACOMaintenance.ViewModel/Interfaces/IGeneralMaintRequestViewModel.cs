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
    public interface IGeneralMaintRequestViewModel
    {
        ObservableCollection<PPE> ppeList { get; set; }
        public int maintId { get; set; }
        public GeneralRequest genralRequestInfo { get; set; }
        public ObservableCollection<User> Users { get; set; }

        public IUsers UsersDataProvider { get; set; }
        public void GetGeneralRequest(int maintId);
        public void LoadAllUsers();
    }
}
