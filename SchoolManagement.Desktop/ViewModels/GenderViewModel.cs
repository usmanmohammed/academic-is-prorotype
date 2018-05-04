using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class GenderViewModel : ViewModelBase
    {
        private HRGender gender;

        public HRGender Gender
        {
            get { return gender; }
            set
            {
                if (gender != value)
                {
                    gender = value;
                    NotifyPropertyChanged("Gender");
                }
            }
        }
    }
}
