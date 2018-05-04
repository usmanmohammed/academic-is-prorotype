using EnterpriseManagement.Data.Models;
using EnterpriseManagement.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class DeductionViewModel : ViewModelBase
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

        private DeductionType deductionType;

        public DeductionType DeductionType
        {
            get { return deductionType; }
            set
            {
                if (deductionType != value)
                {
                    deductionType = value;
                    NotifyPropertyChanged("DeductionType");
                }
            }
        }

        private HRDeductionFrequency deductionFrequency;

        public HRDeductionFrequency DeductionFrequency
        {
            get { return deductionFrequency; }
            set
            {
                if (deductionFrequency != value)
                {
                    deductionFrequency = value;
                    NotifyPropertyChanged("DeductionFrequency");
                }
            }
        }

        private decimal totalAmount;

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set
            {
                if (totalAmount != value)
                {
                    totalAmount = value;
                    NotifyPropertyChanged("TotalAmount");
                }
            }
        }

        private decimal deductionAmount;

        public decimal DeductionAmount
        {
            get { return deductionAmount; }
            set
            {
                if (deductionAmount != value)
                {
                    deductionAmount = value;
                    NotifyPropertyChanged("DeductionAmount");
                }
            }
        }

        private ObservableCollection<DeductionType> deductionTypes;

        public ObservableCollection<DeductionType> DeductionTypes
        {
            get { return deductionTypes; }
            set
            {
                if (deductionTypes != value)
                {
                    deductionTypes = value;
                    NotifyPropertyChanged("DeductionTypes");
                }
            }
        }

        private ObservableCollection<HRDeductionFrequency> deductionFrequencies;

        public ObservableCollection<HRDeductionFrequency> DeductionFrequencies
        {
            get { return deductionFrequencies; }
            set
            {
                if (deductionFrequencies != value)
                {
                    deductionFrequencies = value;
                    NotifyPropertyChanged("DeductionFrequencies");
                }
            }
        }
    }
}
