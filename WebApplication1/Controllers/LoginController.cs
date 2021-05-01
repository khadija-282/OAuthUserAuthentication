using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAuthnetication.Model;
using LoginAuthnetication.Services;
using Microsoft.AspNetCore.Mvc;
namespace LoginAuthentication.Controllers
{
    [Route("api/Login")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly AuthenticateUserService _userservice;
        public LoginController(AuthenticateUserService userservice)
        {
            _userservice = userservice;
        }
        
        [HttpGet]
        [Route("AuthenticateUser")]
        public JsonResult Get(string Email, string Password)
        {
            bool isAuthenticated;
            UserDto userequest = new UserDto()
            {
                Email = Email,
                Password = Password
            };
            isAuthenticated = _userservice.GetAuthenticatedUser(userequest);
            return Json(new { result = isAuthenticated });
        }
    }
}