﻿using SACOMaintenance.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IMaintRequestInitiation
    {
        IEnumerable<MaintRequestInitiation> LoadAllRequestInitations();
        void GetSingleRequestInitiation(int Id);
        void AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation);
    }
}
