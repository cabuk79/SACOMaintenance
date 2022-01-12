using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel
{
    public class AssignMaintStaffToRequestViewModel : IAssignMaintStaffToRequestViewModel
    {
        public ObservableCollection<User> MaintUsers { get; set; } = new();

        public ObservableCollection<User> MaintUsersAssigned { get; set; } = new();
        public MaintRequestInitiation req { get; set; }

        public IUsers UserDataProvider { get; }

        public IMaintRequestInitiation ReqDataPropvider { get; }

     
        public AssignMaintStaffToRequestViewModel(IUsers userDataProvider,
            IMaintRequestInitiation reqdataProvider)
        {
            UserDataProvider = userDataProvider;
            ReqDataPropvider = reqdataProvider;
        }

        public void LoadSingleRequest(int MaintId)
        {
            req = ReqDataPropvider.GetSingleRequestInitiation(MaintId);

            if(req != null)
            {
                foreach (var item in req.Users)
                {
                    MaintUsersAssigned.Add
                        (
                        new User { FirstName = item.FirstName, LastName = item.LastName }
                        );
                }
            }
            
        }

        public async Task LoadUsersAssigned(int maintId)
        {
            var maint = new ObservableCollection<MaintRequestInitiation>
                (await UserDataProvider.GetUsersForMaintReq(maintId));
        }

        public async Task LoadAllUsers(int departmentId)
        {
            var AllMaintUsers = await UserDataProvider.GetUsersByDepartment(departmentId);
        
            foreach(var item in AllMaintUsers)
            {
                MaintUsers.Add(item);
            }
        
        }
    }
}
