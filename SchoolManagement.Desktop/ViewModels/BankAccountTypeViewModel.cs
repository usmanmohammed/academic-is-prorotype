using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class BankAccountTypeViewModel : ViewModelBase
    {
        private HRAccountType accountType;

        public HRAccountType AccountType
        {
            get { return accountType; }
            set
            {
                if (accountType != value)
                {
                    accountType = value;
                    NotifyPropertyChanged("AccountType");
                }
            }
        }
    }
}
