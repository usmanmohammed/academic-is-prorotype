using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class TitlesViewModel : ViewModelBase
    {
        private ObservableCollection<HRTitle> titles;

        public ObservableCollection<HRTitle> Titles
        {
            get { return titles; }
            set
            {
                if (titles != value)
                {
                    titles = value;
                    NotifyPropertyChanged("Titles");
                }
            }
        }
    }
}
