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
    public class SupplierDataProvider : ISupplier
    {
        public readonly SACOMaintenanceContext _sacoMaintenanceContext;

        public SupplierDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _sacoMaintenanceContext = sacoMaintenanceContext;
        }

        public async Task<PostCodeTown> LoadPostCodesByRef(string postCode)
        {
            var postCodes = await _sacoMaintenanceContext.PostCodeTowns
                .Where(pc => pc.PostCode == postCode).FirstOrDefaultAsync();
            return postCodes;
        }

        public async Task<List<Supplier>> LoadAllSuppliers()
        {
            var suppliers = await _sacoMaintenanceContext.Suppliers.ToListAsync();
            return suppliers;
        }

        public async Task<Supplier> LoadSingleSupplier(int Id)
        {
            var singleSupplier = await _sacoMaintenanceContext.Suppliers
                .Where(i => i.Id == Id)
                .Include(sp => sp.SupplierParts)
                .Include(pc => pc.Postcode)
                .FirstOrDefaultAsync();
            
            return singleSupplier;
        }

        public async Task<PostCodeTown> GetPostCode(string postCode)
        {
            var singlePostCode = await _sacoMaintenanceContext.PostCodeTowns.Where(code => code.PostCode == postCode).FirstOrDefaultAsync();
            return singlePostCode;
        }

        public async Task<List<PostCodeTown>> LoadAllPostCodes()
        {
            throw new NotImplementedException();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _sacoMaintenanceContext.Update<Supplier>(supplier);
            _sacoMaintenanceContext.SaveChanges();
        }

        public void AddNewSupplier(Supplier supplier)
        {
            _sacoMaintenanceContext.Add<Supplier>(supplier);
            _sacoMaintenanceContext.SaveChanges();
        }
    }
}
