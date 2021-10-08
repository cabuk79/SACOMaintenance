using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class MaintRequestUsersAssigned
    {
        public int MaintRequestInitiationId { get; set; }
        public string UserId { get; set; }
        public DateTime DateAssigned { get; set; }
    }
}
