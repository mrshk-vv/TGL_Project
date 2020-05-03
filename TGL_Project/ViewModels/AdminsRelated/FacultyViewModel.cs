using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;

namespace TGL_Project.ViewModels.AdminsRelated
{
    public class FacultyViewModel
    {
        public IEnumerable<Faculty> AllFaculties { get; set; }

        public string Name { get; set; }
    }
}
