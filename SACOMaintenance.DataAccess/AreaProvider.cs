using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using SACOMaintenance.Common.ModelDB;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SACOMaintenance.DataAccess
{
    public class AreaProvider : IArea
    {
        private readonly SACOMaintenanceContext _areaDBContext;
        public AreaProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _areaDBContext = sacoMaintenanceContext;
        }

        public void AddEditArea(AreaModel area)
        {
            _areaDBContext.Areas.Add
            (
                new AreaModel
                {
                    AreaName = area.AreaName,
                    CommentsNotes = area.CommentsNotes,
                    FactoryId = area.FactoryId
                }
            );

            _areaDBContext.SaveChanges();
        }

        public async Task<AreaModel> FindAreaByName(string areaName)
        {
            var area = await _areaDBContext.Areas.FirstOrDefaultAsync(n => n.AreaName == areaName);
            return area;
        }

        public async Task<IEnumerable<AreaModel>> LoadAllAreas()
        {
            var areas = await _areaDBContext.Areas.ToListAsync();
            return areas;
        }

        public async Task<IEnumerable<AreaModel>> LoadAreasByFactory(int factoryId)
        {
            IEnumerable<AreaModel> areas = await _areaDBContext.Areas.Where(f => f.FactoryId == factoryId).ToListAsync();
            return areas;
        }

        public async Task<AreaModel> LoadSingleArea(int Id)
        {
            var area = await _areaDBContext.Areas.FirstOrDefaultAsync(i => i.Id == Id);
            return area;
        }

        public void UpdateArea(AreaModel area)
        {
            var areaToUpdate = _areaDBContext.Areas.FirstOrDefault(i => i.Id == area.Id);
            areaToUpdate.AreaName = area.AreaName;
            _areaDBContext.SaveChanges();
        }
    }
}
