using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class DesignationsViewModel : ViewModelBase
    {
        private ObservableCollection<HRDesignation> designations;

        public ObservableCollection<HRDesignation> Designations
        {
            get { return designations; }
            set
            {
                if (designations != value)
                {
                    designations = value;
                    NotifyPropertyChanged("Designations");
                }
            }
        }
    }
}
