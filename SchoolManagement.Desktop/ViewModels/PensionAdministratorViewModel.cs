using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class PensionAdministratorViewModel : ViewModelBase
    {
        private HRPensionAdministrator pensionAdministrator;

        public HRPensionAdministrator PensionAdministrator
        {
            get { return pensionAdministrator; }
            set
            {
                if (pensionAdministrator != value)
                {
                    pensionAdministrator = value;
                    NotifyPropertyChanged("PensionAdministrator");
                }
            }
        }
    }
}
