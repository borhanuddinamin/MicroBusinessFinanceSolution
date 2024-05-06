using Autofac;
using Autofac.Core;
using MBS.Persistence.DIModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Persistence.RegisterDIModule;

public static class RegisterPersistenceModules
{
   
    public static void PersistenceModules(this ContainerBuilder container, string connectionString, string migrationString)
    {
        
        container.RegisterModule(new DbModule(connectionString, migrationString));


    }
}