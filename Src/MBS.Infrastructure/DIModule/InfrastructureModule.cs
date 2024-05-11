using Autofac;
using MBS.Application.DIModule;
using MBS.Infrastructure.Service;


namespace MBS.Infrastructure.DIModule
{
    public class InfrastructureModule:ApplicationDIBaseModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TokenService>().As<TokenService>()
                .InstancePerLifetimeScope();   
            base.Load(builder);
        }
    }
}
