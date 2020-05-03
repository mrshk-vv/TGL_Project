using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TGL_Project.ViewModels;

namespace TGL_Project.Views.Shared.Components
{
    public class TeacherRegistrationViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // await db
            return View(new RegisterTeacherViewModel());
        }

    }
}
