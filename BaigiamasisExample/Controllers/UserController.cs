using BaigiamasisExample.Services;
using BaigiamasisExample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BaigiamasisExample.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IJwtService _jwtService;
        public UserController(IUserService userService, IJwtService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }


        [HttpGet("login")]
        public ActionResult Login(string username, string password)
        {

            if (_userService.Login(username, password, out string role))
            {
                return Ok(_jwtService.GenerateToken(username, role));
            }
            return Unauthorized();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
