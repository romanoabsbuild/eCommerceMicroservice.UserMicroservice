using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            return services;

        } 
    }
}
