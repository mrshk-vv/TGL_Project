﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TGL_Project.ViewModels.AdminsRelated
{
    public class TeacherViewModel
    {
        public string Email { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required]
        [Display(Name = "Телефонный номер")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string AvatarPath { get; set; }

        public string Department { get; set; }

        public string Position { get; set; }

        public List<SelectListItem> DeparmentItems { get; set; }
        public List<SelectListItem> PositionItems { get; set; }

        public bool IsAccepted { get; set; }

        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
    }
}
