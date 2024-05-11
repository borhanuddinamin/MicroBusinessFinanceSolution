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
        public string _connectionString { get; set; }
        public string _migrationString { get; set; }
        public ApplicationDatabase()
        {
            
        }
        public ApplicationDatabase(string connectionString, string migrationString)
        {
            _connectionString= connectionString;
            _migrationString = migrationString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=MBS;Encrypt=False;Trusted_Connection=True; TrustServerCertificate=true", x=>x.MigrationsAssembly("MBS.Persistence, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
