using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TGL_Project.ViewModels.SubjectRelated
{
    public class SubjectInfoViewModel
    {
        public Models.Subject Subject { get; set; }
        public IEnumerable<Models.Task> Tasks { get; set; }

    }
}
