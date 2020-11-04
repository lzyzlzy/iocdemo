using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo
{
    public interface IUserService
    {
        IEnumerable<string> GetNames();

        string GetServiceName();
    }
}
