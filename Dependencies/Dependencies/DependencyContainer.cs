using Data.Repository.Post;
using Data.Repository.User;
using Entities.Contracts.Repository.Post;
using Entities.Contracts.Repository.User;
using Entities.Contracts.Services.Post;
using Entities.Contracts.Services.User;
using Microsoft.Extensions.DependencyInjection;
using Services.Contracts;
using Services.Helper;
using Services.Post;
using Services.User;

namespace IOC.Dependencies
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            #region add Dependencies

            services.AddScoped<IPostServices, PostServices>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJwtService, JwtService>();

            #endregion
        }
    }
}
