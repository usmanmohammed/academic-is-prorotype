using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class NationalityViewModel : ViewModelBase
    {
        private HRNationality nationality;

        public HRNationality Nationality
        {
            get { return nationality; }
            set
            {
                if (nationality != value)
                {
                    nationality = value;
                    NotifyPropertyChanged("Nationality");
                }
            }
        }
    }
}
