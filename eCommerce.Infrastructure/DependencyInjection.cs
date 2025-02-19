using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Método de extensão para adicionar serviços da camada de Infraestructure ao contêiner de injeção de dependência
        /// </summary>
        /// <param name="IServiceCollection"></param>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //TODO: adicionar services ao contêiner de Inversão de Control (IoC - Injecçao de dependência)
            //dos serviços da Infraestrutura frequentemente incluem serviços de acesso a dados, cache, o outros componentes de baixo nível.
            services.AddSingleton<IUserRepository, UserRepository>();
            return services;

        }
    }
}
