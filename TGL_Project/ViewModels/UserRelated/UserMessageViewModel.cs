using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;

namespace TGL_Project.ViewModels.UserRelated
{
    public class UserMessageViewModel
    {
        public User User { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string TextMessage { get; set; }


    }
}
