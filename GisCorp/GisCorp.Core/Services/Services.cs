using GisCorp.Core.Infrastructure.IoC;
using GisCorp.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisCorp.Core.Services
{
    public class Services
    {
        public static IAccountService AccountService { get { return ServiceIoC.Container.Resolve<IAccountService>(); } }
    }
}
