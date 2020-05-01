using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TGL_Project.ViewModels
{
    public class RegisterStudentViewModel : RegisterUserViewModel
    {
        public int GroupId { get; set; }

        public List<SelectListItem> GroupItems { get; set; }
    }
}
