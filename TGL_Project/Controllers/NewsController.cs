using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TGL_Project.Interfaces;
using TGL_Project.Models;
using TGL_Project.Services;

namespace TGL_Project.Controllers
{
    [Authorize(Roles = RoleInitializer.ROLE_ADMIN)]
    public class NewsController : Controller
    {
        private readonly DataBaseContext _dataBaseContext;
        private readonly IDatabaseWorker _databaseWorker;
        private readonly INewsService _newsService;
        public NewsController(DataBaseContext dataBaseContext, IDatabaseWorker databaseWorker, INewsService newsService)
        {
            _dataBaseContext = dataBaseContext;
            _databaseWorker = databaseWorker;
            _newsService = newsService;
        }

        [HttpGet]
        public IActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNew(News nw)
        {
            nw.TimeNew = DateTime.Now;
            await _newsService.AddNews(nw);
            return RedirectToAction("AllNews", "News");
        }

        public IActionResult DeleteNew(int id)
        {
            _newsService.DeleteNews(id);
            return RedirectToAction("AllNews", "News");
        }

        public IActionResult AllNews()
        {

            return View(_dataBaseContext.News.ToList());
        }

    }
}
