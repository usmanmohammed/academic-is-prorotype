using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class GradeSettingViewModel : ViewModelBase
    {
        private SMGradeSetting gradeSetting;

        public SMGradeSetting GradeSetting
        {
            get { return gradeSetting; }
            set
            {
                if (gradeSetting != value)
                {
                    gradeSetting = value;
                    NotifyPropertyChanged("GradeSetting");
                }
            }
        }
    }
}
