using iocdemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iocdemo
{
    public class IoCContainer : IIocContainer
    {
        private readonly Interfaces.IServiceProvider _serviceProvider;

        public IoCContainer(IServiceCollection serviceCollection)
        {
            this._serviceProvider = serviceCollection.BuildProvider();
        }

        public T Inject<T>() where T : class
        {
            var type = typeof(T);
            var constructor = type.GetConstructors().Single();
            var parammeters = constructor.GetParameters().Select(i => _serviceProvider.GetService(i.ParameterType)).ToArray();

            return constructor.Invoke(parammeters) as T;
        }
    }
}
