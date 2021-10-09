﻿using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
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

        public async Task<List<PPE>> LoadAllPlantPPE(string ppeTypeName)
        {
            var ppe = await _ppeDBContext.PPE.Where(t => t.MaintRequestType == ppeTypeName).ToListAsync();
            return ppe;
        }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public async Task<List<PPE>> LoadAllPPE()
        {
            var ppe = await _ppeDBContext.PPE.ToListAsync();
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



        public async Task<PPE> ViewSinglePPEI(int ppeId)
        {
            var ppe = await _ppeDBContext.PPE.FirstOrDefaultAsync(i => i.Id == ppeId);
            return ppe;
        }
    }
}
