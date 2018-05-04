using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Data
{
    public class Session
    {
        public int SessionID { get; set; }
        [StringLength(50)]
        public string SessionDescription { get; set; }
        public DateTime DateCreated { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime DateUpdated { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }
    }
}