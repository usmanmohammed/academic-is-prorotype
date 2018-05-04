using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class QualificationViewModel : ViewModelBase
    {
        private HRQualification qualification;

        public HRQualification Qualification
        {
            get { return qualification; }
            set
            {
                if (qualification != value)
                {
                    qualification = value;
                    NotifyPropertyChanged("Qualification");
                }
            }
        }
    }
}
