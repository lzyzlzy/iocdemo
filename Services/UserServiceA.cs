using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo.Services
{
    public class UserServiceA : IUserService
    {
        public IEnumerable<string> GetNames() => new string[] { "123", "456" };

        public string GetServiceName() => nameof(UserServiceA);
    }
}
