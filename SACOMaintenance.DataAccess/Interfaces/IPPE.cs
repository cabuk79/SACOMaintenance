using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IPPE
    {
        IEnumerable<PPE> LoadAllPPE();
        void SaveAddPPE(PPE ppe);
        PPE ViewSinglePPEI(int Id);
    }
}
