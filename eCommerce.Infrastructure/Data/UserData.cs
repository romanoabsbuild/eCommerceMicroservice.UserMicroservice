using eCommerce.Core.DataContracts;
using eCommerce.Core.Models;
using System.Diagnostics.CodeAnalysis;
using eCommerce.Core.DTO;

namespace eCommerce.Infrastructure.Data
{
    public class UserData : IUserData
    {
        public async Task<ApplicationUser?> AddUser(ApplicationUser user)
        {
            // Gerar o UserID
            user.UserID = Guid.NewGuid();
            
            return user;
        }

        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
        {
            return new ApplicationUser()
            {
                UserID = Guid.NewGuid(),
                Email = email,
                Password = password,
                PersonName = "John Doe",
                Gender = GenderOptions.Masculino.ToString()
            };
        }
    }
}
