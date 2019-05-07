using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TimeTracker.Data;
using TimeTracker.Models;
using TimeTracker.Models.CategoriesViewModels;
using TimeTracker.Models.UserCategoriesViewModels;

namespace TimeTracker.Controllers
{
    [Authorize]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public CategoriesController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Categories


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            var model = new CategoriesIndexViewModel();
            model.Categories = await _context.Categories.Include(c => c.User).Where(c => c.UserId == user.Id).OrderBy(c => c.Title).ToListAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> IndexPost(CategoriesIndexViewModel ViewModel)


            {
                var user = await GetCurrentUserAsync();
                for(int i = 0; i < ViewModel.Categories.Count; i++)
            {
                UserCategory usercategory = new UserCategory
                {
                    UserId = user.Id,
                    CategoryId = ViewModel.Categories[i].Id,
                    MinutesSpent = ViewModel.MinutesSpentList[i],
                    DatePicked = ViewModel.DatePicked
                };
                _context.Add(usercategory);
            }

            await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,UserId")] Category category)
        {
            ModelState.Remove("UserId");
            ModelState.Remove("User");
            var user = await GetCurrentUserAsync();
            if (ModelState.IsValid)
            {
                category.User = user;
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var userCategory = await _context.UserCategories.FindAsync(id);
        //    if (userCategory == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", userCategory.CategoryId);
        //    ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userCategory.UserId);
        //    return View(userCategory);
        //}

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,UserId")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                    var usercategory = _context.UserCategories;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,CategoryId,MinutesSpent,DatePicked")] UserCategory userCategory)
        //{
        //    var category = _context.Categories;
        //    if (id != userCategory.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //                _context.Update(category);
        //                _context.Update(userCategory);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!UserCategoryExists(userCategory.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", userCategory.CategoryId);
        //    ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userCategory.UserId);
        //    return View(userCategory);
        //}

        //private bool UserCategoryExists(int id)
        //{
        //    throw new NotImplementedException();
        //}

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            var usercategory = _context.UserCategories;
            foreach (UserCategory item in usercategory)
            {
                if (item.CategoryId == category.Id)
                {
                    usercategory.Remove(item);
                }
            }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
