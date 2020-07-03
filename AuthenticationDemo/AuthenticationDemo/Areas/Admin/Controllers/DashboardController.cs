using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Membership.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="administrator,superuser")]
    public class DashboardController : Controller
    {
        private readonly RoleManager _roleManager;
        public DashboardController(RoleManager roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            // Role based, Policy Based, Claim based

            // Seed
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> CreateRole()
        {
            await _roleManager.CreateAsync(new Membership.Entities.Role("administrator"));
            await _roleManager.CreateAsync(new Membership.Entities.Role("superuser"));
            return View();
        }
    }
}
