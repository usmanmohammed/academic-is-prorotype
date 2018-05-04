using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class Student
    {
        [Key]
        [StringLength(50)]
        public string StudentID { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string MiddleName { get; set; }

        [StringLength(100)]
        public string Surname { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        [StringLength(100)]
        public string PhoneNumber { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public int? CourseID { get; set; }
        public virtual Course Course { get; set; }

        public bool IsActive { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
