using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class ModuleUploadDetailsViewModel : ViewModelBase
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

        private SMModuleUploadDetail moduleUploadDetails;

        public SMModuleUploadDetail ModuleUploadDetails
        {
            get { return moduleUploadDetails; }
            set
            {
                if (moduleUploadDetails != value)
                {
                    moduleUploadDetails = value;
                    NotifyPropertyChanged("ModuleUploadDetails");
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

    }
}
