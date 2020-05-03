using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TGL_Project.Services;

namespace TGL_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataBaseContext _databaseContext;

        public HomeController(DataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        //Home page
        public IActionResult Index()
        {
            return View(_databaseContext.News.ToList());
        }


    }
}