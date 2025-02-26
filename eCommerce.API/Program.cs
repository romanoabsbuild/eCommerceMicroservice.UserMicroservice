using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.API.Middleware;
using System.Text.Json.Serialization;
using eCommerce.Core.Mappers;

namespace eCommerce.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Adicionar os services da Infraestrutura
            builder.Services.AddInfrastructure();
            // Adicionar os services da Core
            builder.Services.AddCore();

            // Addiconar controllers 
            builder.Services.AddControllers().AddJsonOptions(options => {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

            builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);

            var app = builder.Build();

            // Adicionar o middleware de tratamento de exceções
            app.UseExceptionHandlingMiddleware();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
