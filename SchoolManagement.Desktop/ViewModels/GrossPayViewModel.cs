using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class GrossPayViewModel : ViewModelBase
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
        
        private decimal grossPay;

        public decimal GrossPay
        {
            get { return grossPay; }
            set
            {
                if (grossPay != value)
                {
                    grossPay = value;
                    NotifyPropertyChanged("GrossPay");
                }
            }
        }
    }
}
