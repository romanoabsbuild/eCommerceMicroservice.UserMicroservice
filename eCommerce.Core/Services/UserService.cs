using eCommerce.Core.DTO;
using eCommerce.Core.Models;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServicesContracts;

namespace eCommerce.Core.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserData _userData;

        public UserService(IUserData userData)
        {
            _userData = userData;
        }
        public async Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
        {
            ApplicationUser? user = await _userData.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);
            
            if(user == null)
            {
                return null;
            }

           return new AuthenticationResponse(user.UserID, user.Email, user.PersonName, user.Gender, "token", Success: true);

        }

        public async Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
        {
            ApplicationUser? user = new ApplicationUser()
            {
                Email = registerRequest.Email,
                Password = registerRequest.Password,
                PersonName = registerRequest.PersonName,
                Gender = registerRequest.Gender.ToString()
            };

            ApplicationUser? registerUser = await _userData.AddUser(user);

            if (registerUser == null)
            {
                return null;
            }

            return new AuthenticationResponse(registerUser.UserID, registerUser.Email, registerUser.PersonName, registerUser.Gender, "token", Success: true);
        }
    }
}
