using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class MaritalStatusesViewModel : ViewModelBase
    {
        private ObservableCollection<HRStatus> maritalStatuses;

        public ObservableCollection<HRStatus> MaritalStatuses
        {
            get { return maritalStatuses; }
            set
            {
                if (maritalStatuses != value)
                {
                    maritalStatuses = value;
                    NotifyPropertyChanged("MaritalStatuses");
                }
            }
        }
    }
}
