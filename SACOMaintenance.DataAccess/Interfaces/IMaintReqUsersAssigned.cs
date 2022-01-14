﻿using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IMaintReqUsersAssigned
    {
        void Save(int RequestId, ObservableCollection<User> MaintUsersAssigned);
    }
}
