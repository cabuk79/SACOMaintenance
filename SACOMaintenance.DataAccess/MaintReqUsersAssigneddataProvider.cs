using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;

namespace SACOMaintenance.DataAccess
{
    public class MaintReqUsersAssigneddataProvider : IMaintReqUsersAssigned
    {
        private readonly SACOMaintenanceContext _dbContext;

        public MaintReqUsersAssigneddataProvider(SACOMaintenanceContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Save(int RequestId, ObservableCollection<User> MaintUsersAssigned)
        {
            //Remove the existing entries
            _dbContext.MaintReqUsersAssigned
                .RemoveRange(_dbContext.MaintReqUsersAssigned.Where(i => i.MaintRequestInitiationId == RequestId));

            _dbContext.SaveChanges();

            List<MaintRequestUsersAssigned> NewUsersAssigned = new();

            if (MaintUsersAssigned.Count > 0)
            {
                foreach (var item in MaintUsersAssigned)
                {
                    NewUsersAssigned.Add(new MaintRequestUsersAssigned { MaintRequestInitiationId = RequestId, UserId = item.Id });
                }

                _dbContext.MaintReqUsersAssigned
                    .AddRange(NewUsersAssigned);

                _dbContext.SaveChanges();
            }
        }
    }
}
