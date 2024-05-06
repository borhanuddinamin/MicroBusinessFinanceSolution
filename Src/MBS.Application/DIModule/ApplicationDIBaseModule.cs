

using Autofac;

namespace MBS.Application.DIModule
{
    public abstract class ApplicationDIBaseModule : Module,IDIModule

    {
        protected  override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }

    }
}
