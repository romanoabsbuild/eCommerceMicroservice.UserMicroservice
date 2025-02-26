using eCommerce.Core.DataContracts;
using eCommerce.Core.Models;
using System.Diagnostics.CodeAnalysis;
using eCommerce.Core.DTO;
using eCommerce.Infrastructure.DbContext;

namespace eCommerce.Infrastructure.Data
{
    internal class UserData : IUserData
    {
        private readonly DapperDbContext dbContext;

        public UserData(DapperDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
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
