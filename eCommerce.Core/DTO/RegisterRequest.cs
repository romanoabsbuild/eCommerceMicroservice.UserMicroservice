using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core.DTO
{
    /// <summary>
    /// Representa um objeto de transferência de dados (DTO) para o registro de um usuário
    /// </summary>
    public record RegisterRequest(
        string? Email,
        string? Password,
        string? PersonName,
        GenderOptions Gender
        );
}
