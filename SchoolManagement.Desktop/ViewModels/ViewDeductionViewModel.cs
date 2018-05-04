namespace EnterpriseManagement.Desktop.ViewModels
{
    public class ViewDeductionViewModel : ViewModelBase
    {
        private string deductionType;

        public string DeductionType
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

        private bool isEnabled;

        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    NotifyPropertyChanged("IsEnabled");
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

        private string deductionFrequency;

        public string DeductionFrequency
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
        private decimal totalPaid;

        public decimal TotalPaid
        {
            get { return totalPaid; }
            set
            {
                if (totalPaid != value)
                {
                    totalPaid = value;
                    NotifyPropertyChanged("TotalPaid");
                }
            }
        }

        private decimal outstanding;

        public decimal Outstanding
        {
            get { return outstanding; }
            set
            {
                if (outstanding != value)
                {
                    outstanding = value;
                    NotifyPropertyChanged("Outstanding");
                }
            }
        }
    }
}