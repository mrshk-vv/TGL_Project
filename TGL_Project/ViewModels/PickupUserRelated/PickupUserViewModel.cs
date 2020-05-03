using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TGL_Project.Models;

namespace TGL_Project.ViewModels.PickupUserRelated
{
    public class PickupUserViewModel
    {
        // get ->
        public IEnumerable<User> Users { get; set; }

        public User User;

        public SelectList Faculties { get; set; }
        public SelectList Departments { get; set; }
        public SelectList Groups { get; set; }



    }
}
