using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Risk>> LoadallRisks()
        {
            var risks = await _sacoMaintenanceContext.Risks.ToListAsync();
            return risks;

        }

        public async Task<Risk> ViewSingleRisk(int riskId)
        {
            var risk = await _sacoMaintenanceContext.Risks.FirstOrDefaultAsync(i => i.Id == riskId);
            return risk;
        }
    }
}
