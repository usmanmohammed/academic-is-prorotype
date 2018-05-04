using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class DesignationViewModel : ViewModelBase
    {
        private HRDesignation designation;

        public HRDesignation Designation
        {
            get { return designation; }
            set
            {
                if (designation != value)
                {
                    designation = value;
                    NotifyPropertyChanged("Designation");
                }
            }
        }
    }
}
