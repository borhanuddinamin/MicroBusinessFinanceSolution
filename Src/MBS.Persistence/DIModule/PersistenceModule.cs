

using Autofac;
using MBS.Application.DbContext;
using MBS.Application.DIModule;
using MBS.Persistence.Database;

namespace MBS.Persistence.DIModule;

public class PersistenceModule : ApplicationDIBaseModule
{
    public readonly string _connectionString;
    public readonly string _migrationString;

    public PersistenceModule(string connectionString, string migrationString)
    {
        this._connectionString = connectionString; 
        this._migrationString = migrationString; 
    }

    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);
        builder.RegisterType<ApplicationDatabase>()
            .AsSelf()
            .WithParameter("connectionString", _connectionString)
            .WithParameter("migrationString", _migrationString)
            .InstancePerLifetimeScope();

        builder.RegisterType<ApplicationDatabase>()
            .As<IApplicationDatabase>()
            .WithParameter("connectionString", _connectionString)
            .WithParameter("migrationString", _migrationString)
            .InstancePerLifetimeScope();

        
    }
}
