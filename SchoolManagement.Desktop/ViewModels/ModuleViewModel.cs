using SchoolManagement.Data;
using SchoolManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.ViewModels
{
    public class ModuleViewModel : ViewModelBase
    {
        private Module module;

        public Module Module
        {
            get { return module; }
            set
            {
                if (module != value)
                {
                    module = value;
                    NotifyPropertyChanged("Module");
                }
            }
        }

        private Course selectedCourse;

        public Course SelectedCourse
        {
            get { return selectedCourse; }
            set
            {
                if (selectedCourse != value)
                {
                    selectedCourse = value;
                    NotifyPropertyChanged("SelectedCourse");
                }
            }
        }
    }
}
