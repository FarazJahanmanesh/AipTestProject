using Common.Contracts.Repository.Post;
using Common.Contracts.Repository.User;
using Common.Contracts.Services.Post;
using Data.Repository.Post;
using Data.Repository.User;
using Microsoft.Extensions.DependencyInjection;
using Services.Post;

namespace IOC.Dependencies
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPostServices, PostServices>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
