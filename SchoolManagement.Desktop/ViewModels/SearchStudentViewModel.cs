using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class SearchStudentViewModel : ViewModelBase
    {
        private ObservableCollection<SMStudentInformation> students;

        public ObservableCollection<SMStudentInformation> Students
        {
            get { return students; }
            set
            {
                if (students != value)
                {
                    students = value;
                    NotifyPropertyChanged("Students");
                }
            }
        }
    }
}
