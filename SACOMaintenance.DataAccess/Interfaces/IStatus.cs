﻿using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IStatus
    {
        //IEnumerable<Status> LoadAllStatuses();
        IEnumerable<Status> LoadAllStatuses();
        Status GetSingleStatus(int Id);
        void AddEditStatus(Status status);
    }
}
