using eCommerce.Core.Services;
using eCommerce.Core.ServicesContracts;
using eCommerce.Core.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Método de extensão para adicionar serviços da camada de Core ao contêiner de injeção de dependência
        /// </summary>
        /// <param name="IServiceCollection"></param>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            //TODO: adicionar services ao contêiner de Inversão de Control (IoC - Injecçao de dependência)
            //dos serviços da Infraestrutura frequentemente incluem serviços de acesso a dados, cache, o outros componentes de baixo nível.
            services.AddTransient<IUserService, UserService>();
            services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();

            return services;
        }
    }
}
