using SACOMaintenance.BuisnessModels;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class RiskDataProvider : IRisk
    {
        public void AddEditRisk(Risk risk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Risk> LoadallRisks()
        {
            throw new NotImplementedException();
        }

        public void ViewSingleRisk(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
