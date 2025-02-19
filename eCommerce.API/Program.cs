using eCommerce.Infrastructure;
using eCommerce.Core;

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
            builder.Services.AddControllers();

            var app = builder.Build();
            
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
