using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class MaritalStatusViewModel : ViewModelBase
    {
        private HRStatus maritalStatus;

        public HRStatus MaritalStatus
        {
            get { return maritalStatus; }
            set
            {
                if (maritalStatus != value)
                {
                    maritalStatus = value;
                    NotifyPropertyChanged("MaritalStatus");
                }
            }
        }
    }
}
