using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class NationalitiesViewModel : ViewModelBase
    {
        private ObservableCollection<HRNationality> nationalities;

        public ObservableCollection<HRNationality> Nationalities
        {
            get { return nationalities; }
            set
            {
                if (nationalities != value)
                {
                    nationalities = value;
                    NotifyPropertyChanged("Nationalities");
                }
            }
        }
    }
}
