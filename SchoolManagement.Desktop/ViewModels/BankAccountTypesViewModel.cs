using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class BankAccountTypesViewModel : ViewModelBase
    {
        private ObservableCollection<HRAccountType> accountTypes;

        public ObservableCollection<HRAccountType> AccountTypes
        {
            get { return accountTypes; }
            set
            {
                if (accountTypes != value)
                {
                    accountTypes = value;
                    NotifyPropertyChanged("AccountTypes");
                }
            }
        }
    }
}
