using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class StaffDeductionsViewModel : ViewModelBase
    {
        private StaffViewModel staff;

        public StaffViewModel Staff
        {
            get { return staff; }
            set
            {
                if (staff != value)
                {
                    staff = value;
                    NotifyPropertyChanged("Staff");
                }
            }
        }
        private ObservableCollection<ViewDeductionViewModel> deductions;

        public ObservableCollection<ViewDeductionViewModel> Deductions
        {
            get { return deductions; }
            set
            {
                if (deductions != value)
                {
                    deductions = value;
                    NotifyPropertyChanged("Deductions");
                }
            }
        }

    }
}
