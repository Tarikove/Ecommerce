using Ecommerce.Data;
using Ecommerce.Data.ViewModels;
using Ecommerce.Migrations;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Ecommerce.Controllers
{
    public class ClientController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _context;
        public ClientController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        // GET: ClientController
        public async Task<IActionResult> Index()
        {
            {
                return View(await _context.Client.ToListAsync());
            }

        }

        //// GET: ClientController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<ActionResult> Create(RegisterVM registerVM)
        {
            string returnUrl= Url.Content("~/");
            if (!ModelState.IsValid)
                return View(registerVM);

            var user = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
            if (user != null)
            {
                TempData["EmailError"] = "L'adresse email existe déjà.";
                return View(registerVM);
            }

            //Address address = client.address;
            //_context.Address.Add(registerVM.address);
            var newUser = new Client()
            {
                firstName = registerVM.firstName,
                lastName = registerVM.lastName,
                Email = registerVM.EmailAddress,
                UserName = registerVM.EmailAddress,
                //addressId = address.id,
                civility = registerVM.civility,
                EmailConfirmed = true
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);

            if (newUserResponse.Succeeded)
                Console.WriteLine("User registration succeeded");
            else
            {
                TempData["PwdError"] = "Le mdp n'est pas valide";
                return View(registerVM);
            }

            return View();
        }





        //// GET: ClientController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ClientController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ClientController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ClientController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
