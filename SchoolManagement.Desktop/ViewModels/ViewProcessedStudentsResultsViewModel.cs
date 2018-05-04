using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseManagement.Data.Models;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class ViewProcessedStudentsResultsViewModel : ViewModelBase
    {
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

        private ObservableCollection<SMPreModuleResultEntry> resultEntries;

        public ObservableCollection<SMPreModuleResultEntry> ResultEntries
        {
            get { return resultEntries; }
            set
            {
                if (resultEntries != value)
                {
                    resultEntries = value;
                    NotifyPropertyChanged("ResultEntries");
                }
            }
        }
    }
}
