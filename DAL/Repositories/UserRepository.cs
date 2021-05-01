using LoginAuthnetication.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class UserRepository
    {
        private readonly AuthenticateUserContext _dbcontext;
        public UserRepository(AuthenticateUserContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public bool GetUser(User request)
        {
            bool isAuthenticated = false;
            isAuthenticated = _dbcontext.User.Select(x=>x.Email.ToLower()==request.Email && x.Password==request.Password).ToList().SingleOrDefault();
            return isAuthenticated; 
        }
    }
}
