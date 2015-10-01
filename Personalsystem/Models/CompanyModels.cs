﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Personalsystem.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual ApplicationUser Owner { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }

    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }

    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }

    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
    }
}