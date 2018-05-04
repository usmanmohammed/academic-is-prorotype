using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class EditPostedStudentsResultsViewModel : ViewModelBase
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

        private bool editMode;

        public bool EditMode
        {
            get { return editMode; }
            set
            {
                if (editMode != value)
                {
                    editMode = value;
                    NotifyPropertyChanged("EditMode");
                }
            }
        }

        private bool isCATotal;

        public bool IsCATotal
        {
            get { return isCATotal; }
            set
            {
                if (isCATotal != value)
                {
                    isCATotal = value;
                    NotifyPropertyChanged("IsCATotal");
                }
            }
        }

        private bool isExamTotal;

        public bool IsExamTotal
        {
            get { return isExamTotal; }
            set
            {
                if (isExamTotal != value)
                {
                    isExamTotal = value;
                    NotifyPropertyChanged("IsExamTotal");
                }
            }
        }

        private double caMarked;

        public double CAMarked
        {
            get { return caMarked; }
            set
            {
                if (caMarked != value)
                {
                    caMarked = value;
                    NotifyPropertyChanged("CAMarked");
                }
            }
        }

        public double caOldMarked;


        private double caPercentage;

        public double CAPercentage
        {
            get { return caPercentage; }
            set
            {
                if (caPercentage != value)
                {
                    caPercentage = value;
                    NotifyPropertyChanged("CAPercentage");
                }
            }
        }

        private double examMarked;

        public double ExamMarked
        {
            get { return examMarked; }
            set
            {
                if (examMarked != value)
                {
                    examMarked = value;
                    NotifyPropertyChanged("ExamMarked");
                }
            }
        }

        public double examOldMarked;

        private double examPercentage;

        public double ExamPercentage
        {
            get { return examPercentage; }
            set
            {
                if (examPercentage != value)
                {
                    examPercentage = value;
                    NotifyPropertyChanged("ExamPercentage");
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


        public string resultComponents;
    
        public string ResultComponents
        {
            get { return resultComponents; }
            set
            {
                if (resultComponents != value)
                {
                    resultComponents = value;
                    NotifyPropertyChanged("ResultComponents");
                }
            }
        }

        private DateTime dateUpdated;

        public DateTime DateUpdated
        {
            get { return dateUpdated; }
            set
            {
                if (dateUpdated != value)
                {
                    dateUpdated = value;
                    NotifyPropertyChanged("DateUpdated");
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

        private ObservableCollection<SMPreModuleResultEntry> studentsResults;

        public ObservableCollection<SMPreModuleResultEntry> StudentsResults
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
    }
}
