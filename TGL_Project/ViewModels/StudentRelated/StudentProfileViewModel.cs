using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TGL_Project.Models;

namespace TGL_Project.ViewModels.StudentRelated
{
    public class StudentProfileViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }

    }
}
