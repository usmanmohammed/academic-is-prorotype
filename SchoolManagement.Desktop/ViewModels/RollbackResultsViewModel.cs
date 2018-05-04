using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class RollbackResultsViewModel : ViewModelBase
    {
        private string transactionID;

        public string TransactionID
        {
            get { return transactionID; }
            set
            {
                if (transactionID != value)
                {
                    transactionID = value;
                    NotifyPropertyChanged("TransactionID");
                }
            }
        }
    }
}
