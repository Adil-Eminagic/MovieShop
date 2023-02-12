
using Microsoft.Extensions.DependencyInjection;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Infrastructure
{
    public static class Registry
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IMovieBuysRepository, MovieBuysRepository>();
            services.AddScoped<IMoviesRepository, MoviesRepository>();
            services.AddScoped<IPhotosRepository, PhotosRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();

        }
    }
}
