using SchoolManagement.Data;
using SchoolManagement.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Desktop.ViewModels
{
    public class CourseViewModel : ViewModelBase
    {
        private Course course;

        public Course Course
        {
            get { return course; }
            set
            {
                if (course != value)
                {
                    course = value;
                    NotifyPropertyChanged("Course");
                }
            }
        }
    }
}
