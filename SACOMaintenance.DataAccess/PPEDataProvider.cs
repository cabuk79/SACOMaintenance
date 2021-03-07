using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SACOMaintenance.DataAccess
{
    public class PPEDataProvider : IPPE
    {
        private readonly SACOMaintenanceContext _ppeDBContext;

        public PPEDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
            _ppeDBContext = sacoMaintenanceContext;
        }

        public IEnumerable<PPE> LoadAllPlantPPE(string ppeTypeName)
        {
            var ppe = _ppeDBContext.PPE.Where(t => t.MaintRequestType == ppeTypeName);
            return ppe;
        }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public IEnumerable<PPE> LoadAllPPE()
        {
            var ppe = _ppeDBContext.PPE.ToList();
            return ppe;
        }

        public void SaveAddPPE(PPE ppe)
        {
            _ppeDBContext.PPE.Add
            (
                new PPE 
                { 
                    PPEName = ppe.PPEName,  
                    Description = ppe.Description,
                    MaintRequestType = ppe.MaintRequestType,
                    IconFileLocation = ppe.IconFileLocation
                }
            );
            _ppeDBContext.SaveChanges();
        }



        public PPE ViewSinglePPEI(int ppeId)
        {
            var ppe = _ppeDBContext.PPE.FirstOrDefault(i => i.Id == ppeId);
            return ppe;
        }
    }
}
