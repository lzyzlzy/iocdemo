using iocdemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo.Services
{
    public class RoleServiceB : IRoleService
    {
        public string GetServiceName() => nameof(RoleServiceB);
    }
}
