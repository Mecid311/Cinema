using CinemaPro.Domain.Entity.Membership;
using CinemaPro.Domain.FormModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPro.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        readonly SignInManager<CpUser> signInManager;
        readonly UserManager<CpUser> userManager;
        public AccountController(SignInManager<CpUser> signInManager, UserManager<CpUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginFormModel model)
        {
            if (ModelState.IsValid)
            {
                var foundedUser = await userManager.FindByEmailAsync(model.Username);

                if (foundedUser == null)
                {
                    TempData["Message"] = "Istifadeci tapilmadi";
                    return View(model);
                }

                var signinResult = await signInManager
                    .PasswordSignInAsync(foundedUser, model.Password, true, true);

                if (!signinResult.Succeeded)
                {
                    TempData["Message"] = "Istifadeci adi ve ya sifresi sehvdir";
                    return View(model);
                }
            }
            return RedirectToAction("Index", "Moviedetails");
        }


        
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
           
            return RedirectToAction("login", "account");
        }

    }
}
