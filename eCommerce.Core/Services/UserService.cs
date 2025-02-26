using eCommerce.Core.DTO;
using eCommerce.Core.Models;
using eCommerce.Core.DataContracts;
using eCommerce.Core.ServicesContracts;
using AutoMapper;

namespace eCommerce.Core.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserData _userData;
        private readonly IMapper _mapper;

        public UserService(IUserData userData, IMapper mapper)
        {
            _userData = userData;
            _mapper = mapper;
        }
        public async Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
        {
            ApplicationUser? user = await _userData.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);
            
            if(user == null)
            {
                return null;
            }

            //return new AuthenticationResponse(user.UserID, user.Email, user.PersonName, user.Gender, "token", Success: true);
            return _mapper.Map<AuthenticationResponse>(user) with { Success = true, Token = "token"};

        }

        public async Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
        {
            //ApplicationUser? user = new ApplicationUser()
            //{
            //    Email = registerRequest.Email,
            //    Password = registerRequest.Password,
            //    PersonName = registerRequest.PersonName,
            //    Gender = registerRequest.Gender.ToString()
            //};

            ApplicationUser? user = _mapper.Map<ApplicationUser>(registerRequest);

            ApplicationUser? registerUser = await _userData.AddUser(user);

            if (registerUser == null)
            {
                return null;
            }

            //return new AuthenticationResponse(registerUser.UserID, registerUser.Email, registerUser.PersonName, registerUser.Gender, "token", Success: true);
            return _mapper.Map<AuthenticationResponse>(registerUser) with { Success = true, Token = "token" };
        }
    }
}
