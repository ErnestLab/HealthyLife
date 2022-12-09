using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Authorization;
using HealthyLife.Models;
using HealthyLife.Data;

namespace HealthyLife.Controllers
{
    public class RolesController : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<ApplicationUser> _userManager;
        ApplicationDbContext _db;

        public RolesController(RoleManager<IdentityRole> roleManager, 
            UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            ViewBag.Roles = roles;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            IdentityRole role = new IdentityRole();
            role.Name = name;
            var isExists = await _roleManager.RoleExistsAsync(role.Name);

            if(isExists) 
            {
                ViewBag.mess = "Така роль вже існує!";
                ViewBag.name = name;
                return View();
            }

            var result = await _roleManager.CreateAsync(role);
            if(result.Succeeded)
            {
                TempData["save"] = "Роль успішно була добавлена!";
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

    }
}
