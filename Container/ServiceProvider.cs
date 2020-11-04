using iocdemo.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iocdemo
{
    public class ServiceProvider : iocdemo.Interfaces.IServiceProvider
    {
        private IServiceCollection _serviceCollection;
        private ConcurrentDictionary<Type, object> _objects = new ConcurrentDictionary<Type, object>();

        public ServiceProvider(IServiceCollection serviceCollection)
        {
            this._serviceCollection = serviceCollection;
        }

        public void Dispose()
        {
            _serviceCollection = null;
            _objects = null;
        }

        public object GetService(Type serviceType)
        {
            var matchItem = _serviceCollection.FirstOrDefault(i => i.ServiceType == serviceType);
            if (matchItem == null)
            {
                return null;
            }

            switch (matchItem.LifeTime)
            {
                case ServiceLifeTime.Transient:
                    return Activator.CreateInstance(matchItem.ImplServiceType);
                case ServiceLifeTime.Singleton:
                case ServiceLifeTime.Scoped:
                    {
                        if (_objects.ContainsKey(matchItem.ImplServiceType))
                        {
                            return _objects[matchItem.ServiceType];
                        }

                        var obj = Activator.CreateInstance(matchItem.ImplServiceType);
                        _objects.TryAdd(matchItem.ImplServiceType, obj);
                        return obj;
                    }
                default:
                    return null;
            }
        }
    }
}
