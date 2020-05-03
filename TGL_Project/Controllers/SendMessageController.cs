using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TGL_Project.ViewModels.UserRelated;

namespace TGL_Project.Controllers
{
    public class SendMessageController : Controller
    {
        private readonly EmailService service;
        private readonly ILogger<HomeController> _logger;

        public SendMessageController(ILogger<HomeController> logger, EmailService service)
        {
            _logger = logger;
            this.service = service;
        }

        public IActionResult SendEmailDefault(UserMessageViewModel model)
        {
            service.SendEmailDefault(model.Email, model.Subject, model.TextMessage);
            return RedirectToAction("Index", "Home");
        }


    }
}
