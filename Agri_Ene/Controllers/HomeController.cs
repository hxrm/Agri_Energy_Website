using Agri_Ene.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Agri_Ene.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AgriUser> _userManager;
        private readonly SignInManager<AgriUser> _signInManager;

        public HomeController(ILogger<HomeController> logger, UserManager<AgriUser> userManager, SignInManager<AgriUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
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
        [HttpPost]
        public async Task<IActionResult> GetUserRole()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);
                var roles = await _userManager.GetRolesAsync(user);

                if (roles.Contains("farmer"))
                {
                    return RedirectToAction("Index", "Account"); // Redirect to Account/Index for farmers
                }
                else if (roles.Contains("employee"))
                {
                    return RedirectToAction("Index", "Employee"); // Assuming you have a specific view for employees
                }
                else
                {
                    return RedirectToAction("Index", "Home"); // Default action if role is not matched
                }
            }
            else
            {
                return RedirectToAction("Index", "Home"); // Redirect to home if user is not signed in
            }
        }
    }
}