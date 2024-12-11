using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Models.AppVM
{
    public class RoleVM
    {
        public List<IdentityRole> IdentityRole { get; set; }
    }
}
