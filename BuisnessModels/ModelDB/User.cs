using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comment { get; set; }
        public string AvatarLocation { get; set; }
        public List<MaintReqUptateNote> MaintReqUptateNotes { get; set; } = new();
        public List<MaintRequestInitiation> MaintRequestInitiation { get; set; } = new List<MaintRequestInitiation>();
    }
}
