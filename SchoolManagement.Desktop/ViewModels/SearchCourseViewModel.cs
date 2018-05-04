using SchoolManagement.Data;
using SchoolManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.ViewModels
{
    public class SearchCourseViewModel : ViewModelBase
    {
        private ObservableCollection<Course> courses;

        public ObservableCollection<Course> Courses
        {
            get { return courses; }
            set
            {
                if (courses != value)
                {
                    courses = value;
                    NotifyPropertyChanged("Courses");
                }
            }
        }
    }
}
