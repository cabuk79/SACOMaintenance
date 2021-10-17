using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IIsolationMaintRequestInitiation
    {
        Task<IEnumerable<Isolation>> LoadIsolationsByMaint(int Id);
        Task<List<int>> LoadAllIsolationsIds();
    }
}
