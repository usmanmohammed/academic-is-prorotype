using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class AddModuleToStudentViewModel : ViewModelBase
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

        private string selectedModuleStatus;

        public string SelectedModuleStatus
        {
            get { return selectedModuleStatus; }
            set
            {
                if (selectedModuleStatus != value)
                {
                    selectedModuleStatus = value;
                    NotifyPropertyChanged("SelectedModuleStatus");
                }
            }
        }

        private SMStudentInformation selectedStudent;

        public SMStudentInformation SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                if (selectedStudent != value)
                {
                    selectedStudent = value;
                    NotifyPropertyChanged("SelectedStudent");
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

        private bool selectStudentMode;

        public bool StudentSelectMode
        {
            get { return selectStudentMode; }
            set
            {
                if (selectStudentMode != value)
                {
                    selectStudentMode = value;
                    NotifyPropertyChanged("StudentSelectMode");
                }
            }
        }


        private ObservableCollection<SMStudentInformation> selectedStudents;

        public ObservableCollection<SMStudentInformation> SelectedStudents
        {
            get { return selectedStudents; }
            set
            {
                if (selectedStudents != value)
                {
                    selectedStudents = value;
                    NotifyPropertyChanged("SelectedStudents");
                }
            }
        }
    }
}
