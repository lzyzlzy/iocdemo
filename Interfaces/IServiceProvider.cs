using System;

namespace iocdemo.Interfaces
{
    public interface IServiceProvider : IDisposable
    {
        object GetService(Type serviceType);
    }
}
