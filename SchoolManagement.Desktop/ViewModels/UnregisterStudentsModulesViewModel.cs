using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class UnregisterStudentsModulesViewModel : ViewModelBase
    {
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

        private string selectedLevel;

        public string SelectedLevel
        {
            get { return selectedLevel; }
            set
            {
                if (selectedLevel != value)
                {
                    selectedLevel = value;
                    NotifyPropertyChanged("SelectedLevel");
                }
            }
        }

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

        private ObservableCollection<RegisteredModules> registeredModules;

        public ObservableCollection<RegisteredModules> RegisteredModules
        {
            get { return registeredModules; }
            set
            {
                if (registeredModules != value)
                {
                    registeredModules = value;
                    NotifyPropertyChanged("RegisteredModules");
                }
            }
        }
    }

    public class RegisteredModules : ViewModelBase
    {
        private bool isChecked;

        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    NotifyPropertyChanged("IsChecked");
                }
            }
        }

        private SMStudentRegisteredModule registeredModuleEntry;

        public SMStudentRegisteredModule RegisteredModuleEntry
        {
            get { return registeredModuleEntry; }
            set
            {
                if (registeredModuleEntry != value)
                {
                    registeredModuleEntry = value;
                    NotifyPropertyChanged("RegisteredModuleEntry");
                }
            }
        }
    }
}
