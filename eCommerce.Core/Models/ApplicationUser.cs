namespace eCommerce.Core.Models
{
    /// <summary>
    /// Classe que representa um usuário da aplicação e é o modelo que armazena os dados do usuário
    /// </summary>
    public class ApplicationUser
    {
        public Guid UserID { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PersonName { get; set; }
        public string? Gender { get; set; }
    }
}
