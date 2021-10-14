using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IArea
    {
        Task<IEnumerable<AreaModel>> LoadAllAreas();
        Task<IEnumerable<AreaModel>> LoadAreasByFactory(int factoryId);
        Task<AreaModel> LoadSingleArea(int Id);
        Task<AreaModel> FindAreaByName(string areaName);
        void UpdateArea(AreaModel area);
        void AddEditArea(AreaModel area);
    }
}
