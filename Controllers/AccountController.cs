using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ToDoListProject.Data;
using ToDoListProject.Models;
using ToDoListProject.ViewModels;

namespace ToDoListProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private List<string> _allowedExtentions = new List<string> { ".png", ".jpeg", ".jpg" };
        private int _maxCoverSize = 1048576;
        public AccountController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        private bool ForamtValidation(IFormFile cover)
        {
            if (!_allowedExtentions.Contains(Path.GetExtension(cover.FileName).ToLower()))
            {
                ModelState.AddModelError("Cover", "Invalid image format only ( JPG, JPEG, PNG )");
                return true;
            }
            return false;
        }
        private bool SizeValidation(IFormFile cover)
        {
            if (cover.Length > _maxCoverSize)
            {
                ModelState.AddModelError("Cover", "Cover can't be more than 1 Mb");
                return true;
            }
            return false;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var files = Request.Form.Files;
                if (!files.Any())
                {
                    ModelState.AddModelError("Image", "Please add Image");
                    return View(model);
                }
                var image = files.FirstOrDefault();

                if (ForamtValidation(image))
                    return View(model);


                if (SizeValidation(image))
                    return View(model);

                using var dataStream = new MemoryStream();
                await image.CopyToAsync(dataStream);

                var user = new User()
                {
                    Email = model.Email,
                    UserName = model.FullName,
                    Image = dataStream.ToArray(),
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, true);
                    return RedirectToAction(nameof(Index), "List");
                }
                else
                {
                    foreach (var erorr in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, erorr.Description);
                    }
                }
            }
            return View(model);
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result =
                        await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "List");
                    }
                    else ModelState.AddModelError("", "Incorrect Email Or PassWord");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Email or PassWord");
                }
            }
            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
