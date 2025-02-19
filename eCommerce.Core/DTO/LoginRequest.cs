namespace eCommerce.Core.DTO
{
    /// <summary>
    /// Classe que representa um objeto de transferência de dados (DTO) para a autenticação de um usuário
    /// </summary>
    public record LoginRequest(string? Email, string? Password);
}
