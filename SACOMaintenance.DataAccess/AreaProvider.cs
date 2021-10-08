using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using SACOMaintenance.Common.ModelDB;

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

        public AreaModel FindAreaByName(string areaName)
        {
            var area = _areaDBContext.Areas.FirstOrDefault(n => n.AreaName == areaName);
            return area;
        }

        public IEnumerable<AreaModel> LoadAllAreas()
        {
            var areas = _areaDBContext.Areas.ToList();
            return areas;
        }

        public IEnumerable<AreaModel> LoadAreasByFactory(int factoryId)
        {
            var areas = _areaDBContext.Areas.Where(f => f.FactoryId == factoryId).ToList();
            return areas;
        }

        public AreaModel LoadSingleArea(int Id)
        {
            var area = _areaDBContext.Areas.FirstOrDefault(i => i.Id == Id);
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
