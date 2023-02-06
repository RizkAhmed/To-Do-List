using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListProject.Data;
using ToDoListProject.Models;

namespace ToDoListProject.Controllers
{
    [Authorize]
    public class ListController : Controller
    {
        private AppDbContext _context;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public ListController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var user =await _context.Users.Include(i => i.items).SingleOrDefaultAsync(u=>u.Id==userId);
            if (user == null)
                return RedirectToAction("Login", "Account");
            return View(user);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Item model)
        {
            if(ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                var user = await _context.Users.FindAsync(userId);
                var item = new Item
                {
                    Content = model.Content,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    User = user
                };
                _context.Items.Add(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            var item = await _context.Items.FindAsync(id);
            if (item == null)
                return NotFound();

            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Item model)
        {
            if(ModelState.IsValid)
            {
                var item = await _context.Items.FindAsync(model.Id);

                item.Content = model.Content;
                item.StartDate = model.StartDate;
                item.EndDate = model.EndDate;
                item.ISComplete = model.ISComplete;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            var item = await _context.Items.FindAsync(id);
            if (item == null)
                return NotFound();
            _context.Items.Remove(item);
            _context.SaveChanges();
            return Ok();
        }

    }
}
