using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SACOMaintenance.DataAccess
{
    public class PPEDataProvider : IPPE
    {
        public PPEDataProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public IEnumerable<PPE> LoadAllPPE()
        {
            var ppe = SacoMaintenanceContext.PPE.ToList();
            return ppe;
        }

        public void SaveAddPPE(PPE ppe)
        {
            SacoMaintenanceContext.PPE.Add
            (
                new PPE 
                { 
                    PPEName = ppe.PPEName,  
                    Description = ppe.Description,
                    MaintRequestType = ppe.MaintRequestType,
                    IconFileLocation = ppe.IconFileLocation
                }
            );
            SacoMaintenanceContext.SaveChanges();
        }

        public PPE ViewSinglePPEI(int ppeId)
        {
            var ppe = SacoMaintenanceContext.PPE.FirstOrDefault(i => i.Id == ppeId);
            return ppe;
        }
    }
}
