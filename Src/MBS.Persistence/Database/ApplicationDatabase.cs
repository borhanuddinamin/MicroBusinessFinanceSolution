using MBS.Application.DbContext;
using MBS.Persistence.Features.Membership;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Persistence.Database
{
    public class ApplicationDatabase : IdentityDbContext<ApplicationUser,ApplicationRole,
        Guid,ApplicationUserClaim,ApplicationUserRole,
        ApplicationUserLogin,ApplicationRoleClaim,
        ApplicationUserToken>,
        IApplicationDatabase
    {
        public string connectionString { get; set; }
        public string migrationString { get; set; }
        public ApplicationDatabase(string conString,string migraString)
        {
            connectionString=conString;
            migrationString = migraString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString,x=>x.MigrationsAssembly(migrationString));
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
