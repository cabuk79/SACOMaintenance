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
        IEnumerable<AreaModel> LoadAllAreas();
        AreaModel LoadSingleArea(int Id);
        void AddEditArea(AreaModel area);
        AreaModel FindAreaByName(string areaName);
        void UpdateArea(AreaModel area);
        IEnumerable<AreaModel> LoadAreasByFactory(int factoryId);
    }
}
