using Cafeservello.Modules.Infrastructure.Users.Context;
using Microsoft.EntityFrameworkCore;

namespace Cafeservello.Modules.Presentation.Users.Extensions
{
    public static class Configuration
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
                options.UseMySQL(configuration.GetConnectionString("Database")!));

            return services;
        }
    }
}
