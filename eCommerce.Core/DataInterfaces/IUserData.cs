using eCommerce.Core.Models;

namespace eCommerce.Core.DataContracts
{
    /// <summary>
    /// Interface que define o contrato de implementação de um repositório de usuários
    /// </summary>
    public interface IUserData
    {
        /// <summary>
        /// Adiciona o usuário ao banco de dados, e retorna o recém criado usuário
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<ApplicationUser?> AddUser(ApplicationUser user);


        /// <summary>
        /// Busca um usuário pelo email, validando a senha
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);
    }
}
