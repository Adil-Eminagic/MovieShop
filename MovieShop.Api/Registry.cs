
using Microsoft.EntityFrameworkCore;
using MovieShop.Api.Config;
using MovieShop.Application;
using MovieShop.Infrastructure;


namespace MovieShop.Api
{
    public static class Registry
    {
        public static T BindConfig<T>(this WebApplicationBuilder builder, string key) where T : class 
        {
            var section = builder.Configuration.GetSection(key);
            builder.Services.Configure<T>(section);
            return section.Get<T>()!;

        }

        public static void AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Program), typeof(BaseProfile));
        }

        public static void AddDataBase(this IServiceCollection services, ConnectionStringConfig connectionString)
        {
            services.AddDbContext<DatabaseContext>(options => { options.UseSqlServer(connectionString.Main); });
        }

    }
}
