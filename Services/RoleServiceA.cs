using iocdemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo.Services
{
    public class RoleServiceA : IRoleService
    {
        public string GetServiceName() => nameof(RoleServiceA);
    }
}
