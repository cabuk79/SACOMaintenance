using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.EncryptColumn.Attribute;

namespace SACOMaintenance.Common.ModelDB
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
        public string Comment { get; set; }
        [EncryptColumn]
        public int Pin { get; set; }
        public string AvatarLocation { get; set; }
        public List<MaintReqUptateNote> MaintReqUptateNotes { get; set; } = new();
        public List<MaintRequestInitiation> MaintRequestInitiation { get; set; } = new List<MaintRequestInitiation>();
    }
}
