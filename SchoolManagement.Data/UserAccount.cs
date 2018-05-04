using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public partial class UserAccount
    {
        [Key]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(250)]
        public string FullName { get; set; }

        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime DateUpdated { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }
    }
}
