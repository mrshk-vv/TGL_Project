using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TGL_Project.Interfaces;
using TGL_Project.Models;
using TGL_Project.ViewModels.UserRelated;

namespace TGL_Project.Controllers
{
    public class UserController : Controller
    {
        private readonly IAuthentication _authentication;

        public UserController(IAuthentication authentication)
        {
            _authentication = authentication;
        }

        public async Task<IActionResult> Index(string userId)
        {

            User givenUser = await _authentication.FindUserByIdAsync(userId);

            if (givenUser == null)
            {
                return RedirectToAction("Index", "Home");
            }

            UserMessageViewModel model = new UserMessageViewModel { User = givenUser, Subject = "", TextMessage = "" };
            return View(model);
        }

    }
}
