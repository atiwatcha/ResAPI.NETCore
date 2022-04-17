using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UsersApi.DataAccess.DataAccess.Implementations;
using UsersApi.DataAccess.DataAccess.Interfaces;
using UsersApi.DataAccess.Repositories.Implementations;
using UsersApi.DataAccess.Repositories.Interfaces;

namespace UsersApi.DataAccess
{
    public static class Binder
    {
        public static void Setup(IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<IUsersDataAccess, UsersDataAccess>();
            services.AddTransient<IUsersRespository, UsersRepository>();
        }
    }
}
