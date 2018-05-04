using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class StaffTypeViewModel : ViewModelBase
    {
        private HRStaffType staffType;

        public HRStaffType StaffType
        {
            get { return staffType; }
            set
            {
                if (staffType != value)
                {
                    staffType = value;
                    NotifyPropertyChanged("StaffType");
                }
            }
        }
    }
}
