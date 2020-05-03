using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGL_Project.Interfaces;
using TGL_Project.Models;

namespace TGL_Project.Controllers
{
    public class UserSettingsController : Controller
    {

        private readonly IAuthentication _authentication;
        private readonly IFileService _fileService;


        public UserSettingsController(IAuthentication authentication, IFileService fileService)
        {
            _authentication = authentication;
            _fileService = fileService;
        }

        public async Task<IActionResult> AvatarSettings()
        {
            User currentUser = await _authentication.GetCurrentUserAsync();
            return View(currentUser);
        }

        [HttpPost]
        public async Task<IActionResult> UploadAvatar(IFormFile uploadedFile)
        {
            User currentUser = await _authentication.GetCurrentUserAsync();

            bool res = await _fileService.UploadNewAvatar(currentUser, uploadedFile);

            return RedirectToAction("AvatarSettings");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteAvatar()
        {
            User currentUser = await _authentication.GetCurrentUserAsync();

            await _fileService.DeleteAvatar(currentUser);
            return RedirectToAction("AvatarSettings");
        }

    }
}
