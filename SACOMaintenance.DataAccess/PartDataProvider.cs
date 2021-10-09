﻿using Microsoft.EntityFrameworkCore;
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
    public class PartDataProvider : IPart
    {
        public readonly SACOMaintenanceContext _sacoMaintenanceContext;

        public PartDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _sacoMaintenanceContext = sacoMaintenanceContext;
        }

        public Part GetSinglePartAndSuppliers(int Id)
        {
            var singlePart = _sacoMaintenanceContext.Parts
                .Where(i => i.Id == Id)
                .Include(s => s.SupplierParts)
                .Include(d => d.Drawings)
                .Include(e => e.Equipment)
                .FirstOrDefault();
            return singlePart;
        }

        public async Task<List<Supplier>> LoadAllSuppliers()
        {
            var suppliers = await _sacoMaintenanceContext.Suppliers.ToListAsync();
            return suppliers;
        }

        public async Task<List<Part>> LoadAllPArts()
        {
            var parts = await _sacoMaintenanceContext.Parts.ToListAsync();
            return parts;
        }
    }
}
