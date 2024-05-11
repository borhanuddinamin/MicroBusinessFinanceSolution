using Autofac;
using Autofac.Core;
using MBS.Infrastructure.DIModule;
using MBS.Persistence.DIModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Persistence.DIModule.RegisterDIModule;

public static class RegisterInfrastructureModule
{

    public static void Infrastructure(this ContainerBuilder container)
    {

        container.RegisterModule(new InfrastructureModule());


    }
}