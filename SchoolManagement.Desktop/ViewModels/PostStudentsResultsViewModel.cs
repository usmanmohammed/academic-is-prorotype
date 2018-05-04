using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class PostStudentsResultsViewModel : ViewModelBase
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

        private double resultMarked;

        public double ResultMarked
        {
            get { return resultMarked; }
            set
            {
                if (resultMarked != value)
                {
                    resultMarked = value;
                    NotifyPropertyChanged("ResultMarked");
                }
            }
        }

        private double resultPercentage;

        public double ResultPercentage
        {
            get { return resultPercentage; }
            set
            {
                if (resultPercentage != value)
                {
                    resultPercentage = value;
                    NotifyPropertyChanged("ResultPercentage");
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

        private DateTime datePosted;

        public DateTime DatePosted
        {
            get { return datePosted; }
            set
            {
                if (datePosted != value)
                {
                    datePosted = value;
                    NotifyPropertyChanged("DatePosted");
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

        private ObservableCollection<PostResultViewModel> studentsResults;

        public ObservableCollection<PostResultViewModel> StudentsResults
        {
            get { return studentsResults; }
            set
            {
                if (studentsResults != value)
                {
                    studentsResults = value;
                    NotifyPropertyChanged("StudentsResults");
                }
            }
        }

        private ObservableCollection<SMUploadLog> uploadLogs;

        public ObservableCollection<SMUploadLog> UploadLogs
        {
            get { return uploadLogs; }
            set
            {
                if (uploadLogs != value)
                {
                    uploadLogs = value;
                    //NotifyPropertyChanged("StudentsResults");
                }
            }
        }
    }
}
