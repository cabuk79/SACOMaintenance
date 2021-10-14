using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IRisk
    {
        Task<IEnumerable<Risk>> LoadallRisks();
        Task<Risk> ViewSingleRisk(int Id);
        void AddEditRisk(Risk risk);
    }
}
