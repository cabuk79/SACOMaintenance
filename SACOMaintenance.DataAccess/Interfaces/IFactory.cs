using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IFactory
    {
        Task<IEnumerable<Factory>> LoadAllFactories();
        Task<Factory> ViewSingleFactory(int Id);
        void AddEditFactory(Factory factory);
    }
}
