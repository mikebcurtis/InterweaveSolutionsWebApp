using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using InterweaveSolutionsWebApp.Models;

namespace InterweaveSolutionsWebApp.Controllers.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult TestAdminPage()
        {
            return View();
        }

        [Authorize(Roles = "SuccessAmbassador")]
        public IActionResult TestSuccessAmbassadorPage()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
