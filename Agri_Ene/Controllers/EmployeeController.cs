﻿using Agri_Ene.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Agri_Ene.Controllers
{
    [Authorize(Roles = "employee")]
    public class EmployeeController : Controller
    {
        private readonly UserManager<AgriUser> _userManager;

        public EmployeeController (UserManager<AgriUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Details()
        {
            var agriUser = await _userManager.GetUserAsync(User);
            if (agriUser == null)
            {
                return NotFound();
            }

            return View(agriUser);
        }
    }
}
