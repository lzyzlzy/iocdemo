using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo.Services
{
    public class UserServiceB : IUserService
    {
        public IEnumerable<string> GetNames() => new string[] { "a", "b" };

        public string GetServiceName() => nameof(UserServiceB);
    }
}
