using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TGL_Project.Interfaces;
using TGL_Project.Models;
using TGL_Project.ViewModels.StudentRelated;

namespace TGL_Project.Controllers
{
    [Authorize(Roles = RoleInitializer.ROLE_STUDENT)]
    public class StudentController : Controller
    {

        private readonly IAuthentication _authentication;
        private readonly ISubjectService _subjectService;

        public StudentController(IAuthentication authentication, ISubjectService subjectService)
        {
            _authentication = authentication;
            _subjectService = subjectService;
        }

        public async Task<IActionResult> Profile()
        {
            Student currentStudent = await _authentication.GetCurrentStudentAsync();
            IEnumerable<Subject> subjects = _subjectService.GetSubjectsByStudent(currentStudent);

            StudentProfileViewModel model = new StudentProfileViewModel { Student = currentStudent, Subjects = subjects };
            return View(model);
        }

    }
}
