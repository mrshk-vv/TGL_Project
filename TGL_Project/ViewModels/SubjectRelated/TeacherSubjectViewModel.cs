using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;

namespace TGL_Project.ViewModels.SubjectRelated
{
    public class TeacherSubjectViewModel
    {
        public Subject Subject { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}
