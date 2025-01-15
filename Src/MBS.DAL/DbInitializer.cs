using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MBS.DAL.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public DbInitializer(ApplicationDbContext db, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async void seed()
        {

            string role = "Super Admin";
            role.Trim();
            var roleExist = _roleManager.RoleExistsAsync(role).Result;
            // Create defult roles
            if (!roleExist)
            {
                _roleManager.CreateAsync(new IdentityRole(role)).GetAwaiter().GetResult();
            }

            //Create User

            const string _userName = "ba";
            const string _firstName = "Borhan";
            const string _lastName = "Uddin";
            const string _password = "555555";
            const string _email = "admin@gmail.com";
            
            
           
            _userName.Trim();
            _password.Trim();
            _email.Trim();


            var FindUser = _db.Users.FirstOrDefaultAsync(u => u.UserName == _userName).Result;


            //IdentityResult result;

            if (FindUser == null)
            {

                AppUser appUser = new AppUser();
                appUser.FirstName= _firstName;
                appUser.LastName= _lastName;
                appUser.UserName = _userName;
                appUser.Email = _email;
                appUser.EmailConfirmed = true;
          
              

                //    //_userManager = new UserManager<AppUser>();
                IdentityResult result = _userManager.CreateAsync(appUser, _password).Result;

                if (result.Succeeded)
                {
                    // AppUser user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == _userName);


                    //        // Adding Manager role 
                    IdentityResult DefultRoleresult = _userManager.AddToRoleAsync(appUser, role).Result;

                    if (DefultRoleresult.Succeeded)
                    {
                        _db.SaveChanges();
                    }
                }
            }
        }


        public void AssignRole(AppUser user, string role)
        {
            var res = _userManager.AddToRoleAsync(user, role).Result;
        }
        public async Task UpdateAssignRole(AppUser user, string role)
        {
            UpdateUserRole(user.Id, role);
        }


        public void UpdateUserRole(string userId, string newRoleName)
        {
            try
            {
                // Fetch the existing user-role association for the specified user
                var userRole = _db.UserRoles
                    .FirstOrDefault(ur => ur.UserId == userId);

                // If a user-role association exists, remove it
                if (userRole != null)
                {
                    _db.UserRoles.Remove(userRole);
                    _db.SaveChanges(); // Save changes after removing the role
                }

                // Fetch the new role
                var newRole = _db.Roles
                    .FirstOrDefault(r => r.Name == newRoleName);

                // Check if the new role exists
                if (newRole == null)
                {
                    throw new Exception($"Role '{newRoleName}' not found.");
                }

                // Create a new user-role association
                var newUserRole = new IdentityUserRole<string>
                {
                    UserId = userId,
                    RoleId = newRole.Id
                };

                // Add the new role association
                _db.UserRoles.Add(newUserRole);
                _db.SaveChanges(); // Save changes after adding the new role
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                throw new Exception("An error occurred while updating the user role: " + ex.Message);
            }
        }

        public IEnumerable<IdentityRole> GetAllRole()
        {
            var roles = _db.Roles.ToList();
            return roles;
        }

        public IEnumerable<AppUser> GetAllUser()
        {
            var users = _db.Users.ToList();
           
            return users;
        }

        public async Task<AppUser> GetUserById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return user;
        }

        public void CreateRole(string role)
        {
            var roleExist = _roleManager.RoleExistsAsync(role).Result;
            // Create defult roles
            if (!roleExist)
            {
                _roleManager.CreateAsync(new IdentityRole(role)).GetAwaiter().GetResult();
            }
        }
    }
}
