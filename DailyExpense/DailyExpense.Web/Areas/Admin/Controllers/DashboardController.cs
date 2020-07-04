using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyExpense.Membership.Services;
using DailyExpense.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DailyExpense.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "administrator,superuser")]
    public class DashboardController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly RoleManager _roleManager;
        public DashboardController(RoleManager roleManager)
        {
            _roleManager = roleManager;
        }
        public DashboardController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = new DashboardModel();
            return View(model);
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