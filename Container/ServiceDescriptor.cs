using System;

namespace iocdemo
{
    public class ServiceDescriptor
    {
        public ServiceDescriptor(Type serviceType, Type implServiceType, ServiceLifeTime lifeTime)
        {
            ServiceType = serviceType;
            ImplServiceType = implServiceType;
            LifeTime = lifeTime;
        }

        public Type ServiceType { get; private set; }
        public Type ImplServiceType { get; private set; }
        public ServiceLifeTime LifeTime { get; private set; }
    }
}