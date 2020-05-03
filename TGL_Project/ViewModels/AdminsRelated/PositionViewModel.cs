using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;

namespace TGL_Project.ViewModels.AdminsRelated
{
    public class PositionViewModel
    {
        public string Name { get; set; }

        public IEnumerable<Position> AllPosition { get; set; }
    }
}
