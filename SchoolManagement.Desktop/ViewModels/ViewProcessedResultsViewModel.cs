using EnterpriseManagement.Data.Models;
using EnterpriseManagement.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class ViewProcessedResultsViewModel: ViewModelBase
    {

        private TIMETABLE_TBL selectedTrimester;

        public TIMETABLE_TBL SelectedTrimester
        {
            get { return selectedTrimester; }
            set
            {
                if (selectedTrimester != value)
                {
                    selectedTrimester = value;
                    NotifyPropertyChanged("SelectedTrimester");
                }
            }
        }

        private int selectedTrimesterIndex;

        public int SelectedTrimesterIndex
        {
            get { return selectedTrimesterIndex; }
            set
            {
                if (selectedTrimesterIndex != value)
                {
                    selectedTrimesterIndex = value;
                    NotifyPropertyChanged("SelectedTrimesterIndex");
                }
            }
        }


        private string selectedResultType;

        public string SelectedResultType
        {
            get { return selectedResultType; }
            set
            {
                if (selectedResultType != value)
                {
                    selectedResultType = value;
                    NotifyPropertyChanged("SelectedResultType");
                }
            }
        }

        private ObservableCollection<TIMETABLE_TBL> trimesters;

        public ObservableCollection<TIMETABLE_TBL> Trimesters
        {
            get { return trimesters; }
            set
            {
                if (trimesters != value)
                {
                    trimesters = value;
                    NotifyPropertyChanged("Trimesters");
                }
            }
        }

        private AMModule selectedModule;

        public AMModule SelectedModule
        {
            get { return selectedModule; }
            set
            {
                if (selectedModule != value)
                {
                    selectedModule = value;
                    NotifyPropertyChanged("SelectedModule");
                }
            }
        }

        private bool viewMode;

        public bool ViewMode
        {
            get { return viewMode; }
            set
            {
                if (viewMode != value)
                {
                    viewMode = value;
                    NotifyPropertyChanged("ViewMode");
                }
            }
        }

        private ObservableCollection<ModuleListItem> modules; //ModuleCode, IsChecked

        public ObservableCollection<ModuleListItem> Modules
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
