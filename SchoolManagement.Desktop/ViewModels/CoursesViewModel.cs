using SchoolManagement.Data;
using SchoolManagement.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Desktop.ViewModels
{
    public class CoursesViewModel : ViewModelBase
    {
        private ObservableCollection<Course> banks;

        public ObservableCollection<Course> Courses
        {
            get { return banks; }
            set
            {
                if (banks != value)
                {
                    banks = value;
                    NotifyPropertyChanged("Courses");
                }
            }
        }
    }
}
