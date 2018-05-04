using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Data
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [StringLength(50)]
        public string CourseCode { get; set; }

        [StringLength(250)]
        public string CourseDescription { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public DateTime DateCreated { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime DateUpdated { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }
    }
}