using SACOMaintenance.Common.ModelDB;
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
        private readonly SACOMaintenanceContext _sacoMaintenanceContext;
        public RiskDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
            _sacoMaintenanceContext = sacoMaintenanceContext;
        }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditRisk(Risk risk)
        {
            _sacoMaintenanceContext.Risks.Add
            (
                new Risk { RiskName = risk.RiskName, Description = risk.Description }
            );
            _sacoMaintenanceContext.SaveChanges();
        }

        public IEnumerable<Risk> LoadallRisks()
        {
            var risks = _sacoMaintenanceContext.Risks.ToList();
            return risks;

        }

        public Risk ViewSingleRisk(int riskId)
        {
            var risk = _sacoMaintenanceContext.Risks.FirstOrDefault(i => i.Id == riskId);
            return risk;
        }
    }
}
