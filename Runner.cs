using iocdemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo
{
    public class Runner
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public Runner(IUserService userService, IRoleService roleService)
        {
            this._userService = userService;
            this._roleService = roleService;
        }

        public void Go()
        {
            Console.WriteLine("userservice name:" + _userService.GetServiceName());
            Console.WriteLine("roleservice name:" + _roleService.GetServiceName());
        }

    }
}
