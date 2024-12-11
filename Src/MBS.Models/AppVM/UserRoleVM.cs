using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.AppVM
{
    public class UserRoleVM
    {
        public AppUser AppUser { get; set; }
        public IdentityRole IdentityRole { get; set; }
    }
}
