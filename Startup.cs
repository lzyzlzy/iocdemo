using iocdemo.Interfaces;
using iocdemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace iocdemo
{
    public class Startup
    {

        public Startup()
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IUserService, UserServiceA>()
                    .AddTransient<IRoleService, RoleServiceB>();
        }
    }
}
