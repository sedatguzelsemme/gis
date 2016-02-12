using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GisCorp.Core.Services.Interfaces;
using GisCorp.Core.Services;

namespace GisCorp.Core.Infrastructure.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {


            Register<IAccountService, AccountService>(container);
        }

        public void Register<TInterface, TService>(IWindsorContainer container)
            where TInterface : class
            where TService : TInterface
        {

            container.Register(Component.For<TInterface>()
                  .ImplementedBy<TService>()
                  .LifestyleTransient());
        }
    }
}
