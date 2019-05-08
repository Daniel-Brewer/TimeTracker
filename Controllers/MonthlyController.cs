using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TimeTracker.Data;
using TimeTracker.Models;

namespace TimeTracker.Controllers
{
    public class MonthlyController : Controller
    {
        private readonly UserManager<User> _userManager;

        public MonthlyController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        private readonly ApplicationDbContext _context;

        // GET: Monthly
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.UserCategories.Include(u => u.Category).Include(u => u.User);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> IndexMonth1()
        {
            var user = await GetCurrentUserAsync();
            var applicationDbContext = _context.UserCategories
                .Include(u => u.Category)
                .Include(u => u.User)
                .Where(u => u.UserId == user.Id)
                .Where(u => u.DatePicked >= DateTime.Parse("2019-01-01") && u.DatePicked <= DateTime.Parse("2019-01-31"));
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Monthly/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await GetCurrentUserAsync();
            var userCategory = await _context.UserCategories
                .Include(u => u.Category)
                .Include(u => u.User).Where(u => u.UserId == user.Id)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userCategory == null)
            {
                return NotFound();
            }

            return View(userCategory);
        }

        // GET: Monthly/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id");
            return View();
        }

        // POST: Monthly/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,CategoryId,MinutesSpent,DatePicked")] UserCategory userCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", userCategory.CategoryId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userCategory.UserId);
            return View(userCategory);
        }

        // GET: Monthly/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCategory = await _context.UserCategories.FindAsync(id);
            if (userCategory == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", userCategory.CategoryId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userCategory.UserId);
            return View(userCategory);
        }

        // POST: Monthly/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,CategoryId,MinutesSpent,DatePicked")] UserCategory userCategory)
        {
            if (id != userCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserCategoryExists(userCategory.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", userCategory.CategoryId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userCategory.UserId);
            return View(userCategory);
        }

        // GET: Monthly/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCategory = await _context.UserCategories
                .Include(u => u.Category)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userCategory == null)
            {
                return NotFound();
            }

            return View(userCategory);
        }

        // POST: Monthly/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userCategory = await _context.UserCategories.FindAsync(id);
            _context.UserCategories.Remove(userCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserCategoryExists(int id)
        {
            return _context.UserCategories.Any(e => e.Id == id);
        }
    }
}
