using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class GendersViewModel : ViewModelBase
    {
        private ObservableCollection<HRGender> genders;

        public ObservableCollection<HRGender> Genders
        {
            get { return genders; }
            set
            {
                if (genders != value)
                {
                    genders = value;
                    NotifyPropertyChanged("Genders");
                }
            }
        }
    }
}
