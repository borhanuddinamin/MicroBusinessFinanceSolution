using MBS.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Data
{
    public interface IDbInitializer
    {
        void seed();
        IEnumerable<IdentityRole> GetAllRole();
        IEnumerable<AppUser> GetAllUser();
        Task<AppUser> GetUserById(string id);
        void AssignRole(AppUser user, string role);
        void CreateRole(string role);

        Task UpdateAssignRole(AppUser user, string role);
    }
}
