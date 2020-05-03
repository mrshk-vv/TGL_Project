using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TGL_Project.Interfaces;
using TGL_Project.Models;
using TGL_Project.ViewModels;

namespace TGL_Project.Controllers
{
    [Authorize(Roles = RoleInitializer.ROLE_TEACHER)]
    public class TeacherController : Controller
    {


        private readonly IAuthentication _authentication;
        private readonly IDatabaseWorker _databaseWorker;
        private readonly ISubjectService _subjectService;

        public TeacherController(IAuthentication authentication, IDatabaseWorker databaseWorker, ISubjectService subjectService)
        {

            //   Console.WriteLine(" TEACHER CONTROLLER CONSTRUCTOR ");

            _authentication = authentication;
            _databaseWorker = databaseWorker;
            _subjectService = subjectService;

        }

        public async Task<IActionResult> Profile()
        {

            User currentUser = await _authentication.GetCurrentUserAsync();

            Teacher currentTeacher = await _authentication.GetCurrentTeacherAsync();
            Department department = _authentication.GetTeachersDepartment(currentTeacher);
            Position position = _authentication.GetTeachersPosition(currentTeacher);

            IEnumerable<Subject> subjects = _subjectService.GetSubjectsByTeacher(currentTeacher);

            TeacherProfileViewModel model = new TeacherProfileViewModel
            {
                User = currentUser,
                Department = department,
                Position = position,
                Subjects = subjects
            };

            return View(model);
        }

        public IActionResult AddSubject()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSubject(TeacherProfileViewModel model)
        {

            Teacher teacher = await _authentication.GetCurrentTeacherAsync();
            await _subjectService.AddSubject(model.Subject, teacher.Id);

            return RedirectToAction("Profile");
        }

    }
}
