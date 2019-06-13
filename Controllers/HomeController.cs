using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimeTracker.Data;
using TimeTracker.Models;

namespace TimeTracker.Controllers

{
   
    public class HomeController : Controller
{

    private readonly ApplicationDbContext _context;
    private readonly UserManager<User> _userManager;

        public HomeController(ApplicationDbContext context,UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: Categories
        public async Task<IActionResult> Index()
    {
            List<Category> applicationDbContext = _context.Categories.ToList();
            return View(applicationDbContext);
        }

    // GET: Categories/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var category = await _context.Categories
            .Include(c => c.UserId).OrderBy(c => c.Title)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (category == null)
        {
            return NotFound();
        }

        return View(category);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}
