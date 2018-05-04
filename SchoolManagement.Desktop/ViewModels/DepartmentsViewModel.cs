using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class DepartmentsViewModel : ViewModelBase
    {
        private ObservableCollection<HRDepartment> departments;

        public ObservableCollection<HRDepartment> Departments
        {
            get { return departments; }
            set
            {
                if (departments != value)
                {
                    departments = value;
                    NotifyPropertyChanged("Departments");
                }
            }
        }
    }
}
