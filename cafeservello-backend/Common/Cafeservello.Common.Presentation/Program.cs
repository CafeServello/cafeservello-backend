
using Cafeservello.Common.Application.Interfaces.Service;
using Cafeservello.Common.Application.Services;
using Cafeservello.Common.Domain.Interfaces.Repository;
using Cafeservello.Common.Domain.Interfaces.Service;
using Cafeservello.Common.Domain.Services;
using Cafeservello.Common.Infrastructure.Repository;

namespace Cafeservello.Common.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
