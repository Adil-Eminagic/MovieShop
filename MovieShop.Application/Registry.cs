
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MovieShop.Application.Interfaces;
using MovieShop.Core;

namespace MovieShop.Application
{
    public static class Registry
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IMoviesService, MoviesService>();
            services.AddScoped<IMovieBuysService, MovieBuysService>();         
            services.AddScoped<IPhotosService, PhotosService>();          
            services.AddScoped<IUsersService, UsersService>();         
        }

        public static void AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<PhotoUpsertDto>, PhotoValidator>();
            services.AddScoped<IValidator<MovieUpsertDto>, MovieValidator>();
            services.AddScoped<IValidator<MovieBuyUpsertDto>, MovieBuyValidator>();
            services.AddScoped<IValidator<UserUpsertDto>, UserValidator>();
            // TODO: Add other validators
        }
    }
}
