using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _usManager;
        public UserController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;

        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();

            /*.Include(t => t.Id); */           //var users = userManager.Users.ToList();

            return View(users);
         }

       
       

    }
}
