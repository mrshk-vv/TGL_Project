﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TGL_Project.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TheoryPath { get; set; }
        public DateTime DeadlineTime { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

    }
}
