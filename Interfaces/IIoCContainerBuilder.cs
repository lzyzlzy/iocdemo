using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo.Interfaces
{
    public interface IIoCContainerBuilder
    {
        IIocContainer Build();

        IIoCContainerBuilder ConfigureServices(Action<IServiceCollection> configureServices);
    }
}
