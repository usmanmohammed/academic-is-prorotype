using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class GradeSettingsViewModel : ViewModelBase
    {
        private ObservableCollection<SMGradeSetting> gradeSettings;

        public ObservableCollection<SMGradeSetting> GradeSettings
        {
            get { return gradeSettings; }
            set
            {
                if (gradeSettings != value)
                {
                    gradeSettings = value;
                    NotifyPropertyChanged("GradeSettings");
                }
            }
        }
    }
}
