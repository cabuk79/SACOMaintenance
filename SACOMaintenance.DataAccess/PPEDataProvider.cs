using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<PPE>> LoadAllPlantPPE(string ppeTypeName)
        {
            var ppe = await _ppeDBContext.PPE.Where(t => t.MaintRequestType == ppeTypeName).ToListAsync();
            return ppe;
        }

        //public async Task<IEnumerable<PPE>> GetPpeAndRequests(int maintId)
        //{
        //    from maintRequestInitation in _ppeDBContext.MaintRequestInitiations
        //    where maintRequestInitation.Id == maintId
        //    from ppe in maintRequestInitation.PPEEquipment
        //    select ppe;
        //}

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public async Task<IEnumerable<PPE>> LoadAllPPE()
        {
            var ppe = await _ppeDBContext.PPE
                .Include(m => m.MaintRequestInitiations)
                .ToListAsync();
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

        /// <summary>
        /// Updates the PPE list for the chosen maintenance request
        /// </summary>
        /// <param name="PPEItems">The list of selected PPE</param>
        /// <param name="MaintId">the request Id</param>
        public void UpdatePPE(List<PPE> PPEItems, int MaintId)
        {
            //Get the maintenance request
            var Request = _ppeDBContext.MaintRequestInitiations.Where(id => id.Id == MaintId).FirstOrDefault();

            //Remove the PPE equipment if any
            Request.PPEEquipment.Clear();

            //Loop through the PPEITems and add to the Request
            foreach(var item in PPEItems)
            {
                Request.PPEEquipment.Add(item);
            }

            //update and save
            _ppeDBContext.Update(Request);
            _ppeDBContext.SaveChanges();
            
        }

        public async Task<PPE> ViewSinglePPEI(int ppeId)
        {
            var ppe = await _ppeDBContext.PPE.FirstOrDefaultAsync(i => i.Id == ppeId);
            return ppe;
        }
    }
}
