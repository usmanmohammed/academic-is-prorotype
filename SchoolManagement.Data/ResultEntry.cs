using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class ResultEntry
    {
        [Key]
        public int EntryID { get; set; }

        [StringLength(50)]
        public string StudentID { get; set; }

        [StringLength(50)]
        public string ModuleCode { get; set; }

        [StringLength(50)]
        public string Session { get; set; }

        [StringLength(50)]
        public string Semester { get; set; }

        [StringLength(50)]
        public string Level { get; set; }

        [StringLength(50)]
        public string CourseStatus { get; set; }

        public double? CAMarked { get; set; }

        public double? CAScore { get; set; }

        public double? ExamMarked { get; set; }

        public double? ExamScore { get; set; }

        public double? Total { get; set; }

        [StringLength(20)]
        public string Grade { get; set; }

        [StringLength(20)]
        public string Decision { get; set; }

        public virtual Module Module { get; set; }
    }
}
