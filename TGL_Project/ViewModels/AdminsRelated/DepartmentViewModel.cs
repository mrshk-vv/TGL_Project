using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;

namespace TGL_Project.ViewModels.AdminsRelated
{
    public class DepartmentViewModel
    {
        public string Name { get; set; }

        public int FacultyId { get; set; }

        public List<SelectListItem> FacultyItems { get; set; }

        public IEnumerable<Department> AllDepartments { get; set; }


    }
}