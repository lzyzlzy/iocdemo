using iocdemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo
{
    public class IoCContainerBuilder : IIoCContainerBuilder
    {
        private IServiceCollection _services;

        public IoCContainerBuilder()
        {
            _services = new ServiceCollection();
        }

        public IIocContainer Build()
        {
            return new IoCContainer(_services);
        }

        public IIoCContainerBuilder ConfigureServices(Action<IServiceCollection> configureServices)
        {
            configureServices(_services);
            return this;
        }
    }
}
