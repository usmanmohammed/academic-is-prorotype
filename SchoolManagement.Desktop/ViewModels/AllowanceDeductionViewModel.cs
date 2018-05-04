using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class AllowanceDeductionPostType
    {
        public int PostTypeID { get; set; }
        public string PostTypeTitle { get; set; }
    }

    public class AllowanceDeductionViewModel : INotifyPropertyChanged
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

        private GeneralLedgerAccount generalLedgerAccount;

        public GeneralLedgerAccount GeneralLedgerAccount
        {
            get { return generalLedgerAccount; }
            set
            {
                if (generalLedgerAccount != value)
                {
                    generalLedgerAccount = value;
                    NotifyPropertyChanged("GeneralLedgerAccount");
                }
            }
        }

        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set
            {
                if (amount != value)
                {
                    amount = value;
                    NotifyPropertyChanged("Amount");
                }
            }
        }

        private DateTime postDate;

        public DateTime PostDate
        {
            get { return postDate; }
            set
            {
                if (postDate != value)
                {
                    postDate = value;
                    NotifyPropertyChanged("PostDate");
                }
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        private AllowanceDeductionPostType postType;

        public AllowanceDeductionPostType PostType
        {
            get { return postType; }
            set
            {
                if (postType != value)
                {
                    postType = value;
                    NotifyPropertyChanged("PostType");
                }
            }
        }

        private ObservableCollection<AllowanceDeductionPostType> postTypes;

        public ObservableCollection<AllowanceDeductionPostType> PostTypes
        {
            get { return postTypes; }
            set
            {
                if (postTypes != value)
                {
                    postTypes = value;
                    NotifyPropertyChanged("PostTypes");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
