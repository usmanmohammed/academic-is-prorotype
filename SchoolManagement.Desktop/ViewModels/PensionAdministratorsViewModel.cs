using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class PensionAdministratorsViewModel : ViewModelBase
    {
        private ObservableCollection<HRPensionAdministrator> pensionAdminstrators;

        public ObservableCollection<HRPensionAdministrator> PensionAdministrators
        {
            get { return pensionAdminstrators; }
            set
            {
                if (pensionAdminstrators != value)
                {
                    pensionAdminstrators = value;
                    NotifyPropertyChanged("PensionAdministrators");
                }
            }
        }
    }
}
