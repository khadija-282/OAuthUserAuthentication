using DAL;
using DAL.Repositories;
using LoginAuthnetication.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LoginAuthnetication.Services
{
    public class AuthenticateUserService
    {
        private readonly AuthenticateUserContext _context;
        private readonly UserRepository _userrepo;
        public AuthenticateUserService( AuthenticateUserContext context, UserRepository userrepo )
        {
            _context = context;
            _userrepo = userrepo;
        }
        public bool GetAuthenticatedUser(UserDto userRequest)
        {
            bool isAuthenticated = false;
            User userinDB = new User()
            {
                Email = userRequest.Email,
                Password = userRequest.Password
            };
            isAuthenticated = _userrepo.GetUser(userinDB);
            return isAuthenticated;
        }
    }
}
