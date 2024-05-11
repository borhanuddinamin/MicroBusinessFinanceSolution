using Autofac;
using MBS.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Application.DIModule
{
    public class ApplicationModule : ApplicationDIBaseModule
    {
        protected override void Load(ContainerBuilder builder)
        {


            base.Load(builder);
        }
    }
}
