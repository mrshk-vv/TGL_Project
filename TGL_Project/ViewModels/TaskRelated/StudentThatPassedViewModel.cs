using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;

namespace TGL_Project.ViewModels.TaskRelated
{
    public class StudentThatPassedViewModel
    {
        public IEnumerable<N_To_N_TaskStudent> TaskStudents { get; set; }
        public Models.Task Task { get; set; }

    }
}
