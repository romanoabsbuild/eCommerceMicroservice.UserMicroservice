using eCommerce.Core.DTO;

namespace eCommerce.Core.ServicesContracts
{
    /// <summary>
    /// Contracto para a implementação de um serviço de usuário, com os seus casos de uso
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Método que trata do login do usuário, e retorna o objecto de AuthenticationResponse com o status do Login - 
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        Task<AuthenticationResponse?> Login(LoginRequest loginRequest);

        /// <summary>
        /// Método que trata do registo do usuário, e retorna o objecto de AuthenticationResponse com o status do RSegisto
        /// </summary>
        /// <param name="registerRequest"></param>
        /// <returns></returns>
        Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);
    }
}
