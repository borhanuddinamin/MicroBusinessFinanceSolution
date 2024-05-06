using Autofac;
using Autofac.Core.Registration;
using MBS.Application.DbContext;
using MBS.Application.DIModule;
using MBS.Persistence.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Persistence.DIModule
{
    public class DbModule : ApplicationDIBaseModule
    {
        public string connectionString { get; set; }
        public string migrationString { get; set; }
        public DbModule(string conString, string migraString)
        {
            connectionString = conString;
            migrationString = migraString;
        }


        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ApplicationDatabase>().AsSelf()
                .WithParameter("connectionString", connectionString)
                .WithParameter("migrationString", migrationString)
                .InstancePerLifetimeScope();

            builder.RegisterType<IApplicationDatabase>().AsSelf()
                .WithParameter("connectionString", connectionString)
                .WithParameter("migrationString", migrationString)
                .InstancePerLifetimeScope();
            base.Load(builder);

        }


    }
}
