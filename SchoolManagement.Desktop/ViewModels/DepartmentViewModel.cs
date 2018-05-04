using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class DepartmentViewModel : ViewModelBase
    {
        private HRDepartment department;

        public HRDepartment Department
        {
            get { return department; }
            set
            {
                if (department != value)
                {
                    department = value;
                    NotifyPropertyChanged("Department");
                }
            }
        }
    }
}
