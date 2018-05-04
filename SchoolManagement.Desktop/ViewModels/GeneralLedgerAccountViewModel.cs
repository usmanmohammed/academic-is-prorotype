using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class GeneralLedgerAccountViewModel : ViewModelBase
    {
        private ObservableCollection<GeneralLedgerAccount> generalLedgerAccounts;

        public ObservableCollection<GeneralLedgerAccount> GeneralLedgerAccounts
        {
            get { return generalLedgerAccounts; }
            set
            {
                if (generalLedgerAccounts != value)
                {
                    generalLedgerAccounts = value;
                    NotifyPropertyChanged("GeneralLedgerAccounts");
                }
            }
        }
    }
}
