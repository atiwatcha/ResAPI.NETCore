using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using UsersApi.Business.Managers.Implementations;
using UsersApi.Business.Managers.Interfaces;

namespace UsersApi.Business
{
    public static class Binder
    {
        public static void Setup(IServiceCollection services)
        {
            services.AddTransient<IUsersManager, UsersManager>();
        }
    }
}