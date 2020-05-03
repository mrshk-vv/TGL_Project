using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TGL_Project.ViewModels.TaskRelated
{
    public class AddTaskViewModel
    {
        public int SubjectId { get; set; }
        public string TaskName { get; set; }
        public DateTime Deadline { get; set; }
        public IFormFile UploadedFile { get; set; }

    }
}
