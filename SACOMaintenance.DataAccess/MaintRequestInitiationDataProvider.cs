using SACOMaintenance.BuisnessModels;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class MaintRequestInitiationDataProvider : IMaintRequestInitiation
    {
        public void AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation)
        {
            throw new NotImplementedException();
        }

        public MaintRequestInitiation GetSingleRequestInitiation(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaintRequestInitiation> LoadAllRequestInitations()
        {
            throw new NotImplementedException();
        }
    }
}
