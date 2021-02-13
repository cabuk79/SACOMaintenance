using SACOMaintenance.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IRisk
    {
        IEnumerable<Risk> LoadallRisks();
        Risk ViewSingleRisk(int Id);
        void AddEditRisk(Risk risk);
    }
}
