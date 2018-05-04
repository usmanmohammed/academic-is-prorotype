using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class PaymentHistoryViewModel : ViewModelBase
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

        private decimal totalAllowance;

        public decimal TotalAllowance
        {
            get { return totalAllowance; }
            set
            {
                if (totalAllowance != value)
                {
                    totalAllowance = value;
                    NotifyPropertyChanged("TotalAllowance");
                }
            }
        }

        private decimal totalDeduction;

        public decimal TotalDeduction
        {
            get { return totalDeduction; }
            set
            {
                if (totalDeduction != value)
                {
                    totalDeduction = value;
                    NotifyPropertyChanged("TotalDeduction");
                }
            }
        }

        private ObservableCollection<HRSalaryEntry> salaryEntries;

        public ObservableCollection<HRSalaryEntry> SalaryEntries
        {
            get { return salaryEntries; }
            set
            {
                if (salaryEntries != value)
                {
                    salaryEntries = value;
                    NotifyPropertyChanged("SalaryEntries");
                }
            }
        }
    }
}
