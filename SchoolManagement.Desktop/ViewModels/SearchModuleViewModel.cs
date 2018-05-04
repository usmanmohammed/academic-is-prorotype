using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.ViewModels
{
    public class SearchModuleViewModel : ViewModelBase
    {
        private ObservableCollection<Module> modules;

        public ObservableCollection<Module> Modules
        {
            get { return modules; }
            set
            {
                if (modules != value)
                {
                    modules = value;
                    NotifyPropertyChanged("Modules");
                }
            }
        }
    }
}
