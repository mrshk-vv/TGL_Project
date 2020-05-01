using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;

namespace TGL_Project.ViewModels
{
    public class TeacherProfileViewModel
    {
        public User User { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }


        public Subject Subject { get; set; }
    }
}
