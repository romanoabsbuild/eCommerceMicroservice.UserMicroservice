using Dapper;
using eCommerce.Core.DataContracts;
using eCommerce.Core.DTO;
using eCommerce.Core.Models;
using eCommerce.Infrastructure.DbContext;

namespace eCommerce.Infrastructure.Data
{
    internal class UserData : IUserData
    {
        private readonly DapperDbContext _dbContext;

        public UserData(DapperDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ApplicationUser?> AddUser(ApplicationUser user)
        {
            // Gerar o UserID
            user.UserID = Guid.NewGuid();

            string query = "INSERT INTO public.\"Users\"(\"UserID\", \"Email\", \"PersonName\", \"Gender\", \"Password\") VALUES(@UserID, @Email, @PersonName, @Gender, @Password)";
            
            int rowCountAffected =  await _dbContext.DbConnection.ExecuteAsync(query, user);

            if (rowCountAffected > 0) 
            {
                return user;
            }
            else{
                return null;
            }
        }

        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
        {

            string query = "SELECT * FROM public.\"Users\" WHERE \"Email\"=@Email AND \"Password\"=@Password";
            var parameters = new { Email = email, Password = password };
            ApplicationUser? user = await _dbContext.DbConnection.QueryFirstOrDefaultAsync<ApplicationUser>(query, parameters);
            return user;
        }
    }
}
