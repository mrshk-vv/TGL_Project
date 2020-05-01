using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TGL_Project.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Contents { get; set; }
        public DateTime TimeNew { get; set; }
    }
}
