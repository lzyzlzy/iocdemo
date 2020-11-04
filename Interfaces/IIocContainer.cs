using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo.Interfaces
{
    public interface IIocContainer
    {
        T Inject<T>() where T : class;
    }
}
