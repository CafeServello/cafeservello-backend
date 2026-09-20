using Cafeservello.Modules.Application.Users.Interfaces;
using Cafeservello.Modules.Application.Users.Services;
using Cafeservello.Modules.Domain.Users.Interfaces.Repository;
using Cafeservello.Modules.Infrastructure.Users.Repository;
using Cafeservello.Modules.Presentation.Users.Extensions;
using System.Reflection;

namespace Cafeservello.Modules.Presentation.Users
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDatabase(builder.Configuration);

            builder.Services.AddControllers();

            builder.Services.AddScoped<IUserApp, UserApp>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(options =>
            {
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFilename);

                options.IncludeXmlComments(xmlPath);
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Café Servello API v1");
                    options.RoutePrefix = "swagger";
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}