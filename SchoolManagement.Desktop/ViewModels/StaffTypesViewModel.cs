using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class StaffTypesViewModel : ViewModelBase
    {
        private ObservableCollection<HRStaffType> staffTypes;

        public ObservableCollection<HRStaffType> StaffTypes
        {
            get { return staffTypes; }
            set
            {
                if (staffTypes != value)
                {
                    staffTypes = value;
                    NotifyPropertyChanged("StaffTypes");
                }
            }
        }
    }
}
