using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
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
        public RiskDataProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditRisk(Risk risk)
        {
            SacoMaintenanceContext.Risks.Add
            (
                new Risk { RiskName = risk.RiskName, Description = risk.Description }
            );
            SacoMaintenanceContext.SaveChanges();
        }

        public IEnumerable<Risk> LoadallRisks()
        {
            var risks = SacoMaintenanceContext.Risks.ToList();
            return risks;
        }

        public Risk ViewSingleRisk(int riskId)
        {
            var risk = SacoMaintenanceContext.Risks.FirstOrDefault(i => i.Id == riskId);
            return risk;
        }
    }
}
