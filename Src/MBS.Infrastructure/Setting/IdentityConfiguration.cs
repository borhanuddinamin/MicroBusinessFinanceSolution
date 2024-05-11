using Autofac.Core;
using MBS.Persistence.Database;
using MBS.Persistence.Features.Membership;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Infrastructure.AuthSetting;

public static class IdentityConfiguration
{

    public static void IdentityConfig(this IServiceCollection services)
    {
        services
            .AddIdentity<ApplicationUser, ApplicationRole>()
            .AddEntityFrameworkStores<ApplicationDatabase>()
            .AddUserManager<ApplicationUserManager>()
            .AddRoleManager<ApplicationRoleManeger>()
            .AddSignInManager<ApplicationSignInManager>()
            .AddDefaultTokenProviders();
        services
            .Configure<IdentityOptions>(options =>
            {   options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;

                options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(15);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers=true;


                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                options.User.RequireUniqueEmail = true;

            });

        
    }

}
