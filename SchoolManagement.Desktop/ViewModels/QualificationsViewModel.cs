using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class QualificationsViewModel : ViewModelBase
    {
        private ObservableCollection<HRQualification> qualifications;

        public ObservableCollection<HRQualification> Qualifications
        {
            get { return qualifications; }
            set
            {
                if (qualifications != value)
                {
                    qualifications = value;
                    NotifyPropertyChanged("Qualifications");
                }
            }
        }
    }
}
