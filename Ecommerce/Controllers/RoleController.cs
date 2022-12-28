using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Ecommerce.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        
        
    
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<IdentityUser> _userManager;
        public RoleController(RoleManager<IdentityRole>roleManager, UserManager<IdentityUser>userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;


        }
        [Authorize (Roles ="Admin")]
        public IActionResult Index()
        {

            var roles = _roleManager.Roles.ToList();
           
                /*.Include(t => t.Id); */           //var users = userManager.Users.ToList();

            return View (roles);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateRole()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult>CreateRole(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return View ();

        }

        public async Task<IActionResult> GetMyRoles()

        {
            var usermail = User.FindFirstValue(ClaimTypes.Email);
            var user = await _userManager.FindByEmailAsync(usermail);
            var roles = await _userManager.GetRolesAsync(user);
            return View(roles);
        }


    }
}
