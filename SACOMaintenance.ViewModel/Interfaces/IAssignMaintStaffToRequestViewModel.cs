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
    public interface IAssignMaintStaffToRequestViewModel
    {
        public ObservableCollection<User> MaintUsers { get; set; }
        public ObservableCollection<User> MaintUsersAssigned { get; set; }
        public MaintRequestInitiation req { get; set; }
        IUsers UserDataProvider { get; }
        IMaintReqUsersAssigned MaintUserAssignedProvider { get; }
        //Task LoadUsersAssigned(int maintId);
        void LoadSingleRequest(int MaintId);
        Task LoadAllUsers(int departmentId);
        void SaveAssignedUsers(int requestId);
    }
}
