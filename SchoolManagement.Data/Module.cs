using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class Module
    {
        [Key]
        [StringLength(20)]
        public string ModuleCode { get; set; }

        [StringLength(100)]
        public string ModuleDescription { get; set; }

        [StringLength(50)]
        public string ModuleType { get; set; }

        public int? CreditLoad { get; set; }

        [StringLength(20)]
        public string CourseLevel { get; set; }

        public int CourseID { get; set; }

        [StringLength(20)]
        public string Semester { get; set; }

        public virtual Course Course { get; set; }
        public DateTime DateCreated { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime DateUpdated { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }
    }
}
