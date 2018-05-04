using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class PostResultViewModel : ViewModelBase
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }

        private double? rawMarks;

        public double? RawMarks
        {
            get { return rawMarks; }
            set
            {
                if (rawMarks != value)
                {
                    rawMarks = value;
                    NotifyPropertyChanged("RawMarks");
                }
            }
        }

        private SMStudentInformation studentInformation;

        public SMStudentInformation StudentInformation
        {
            get { return studentInformation; }
            set
            {
                if (studentInformation != value)
                {
                    studentInformation = value;
                    //NotifyPropertyChanged("StudentInformation");
                }
            }
        }

        private SMPreModuleResultEntry studentResult;

        public SMPreModuleResultEntry StudentResult
        {
            get { return studentResult; }
            set
            {
                if (studentResult != value)
                {
                    studentResult = value;
                    NotifyPropertyChanged("StudentResult");
                }
            }
        }

        private bool resultExists;

        public bool ResultExists
        {
            get { return resultExists; }
            set
            {
                if (resultExists != value)
                {
                    resultExists = value;
                    //NotifyPropertyChanged("ResultExists");
                }
            }
        }

        private SMStudentRegisteredModule studentRegisteredModule;

        public SMStudentRegisteredModule StudentRegisteredModule
        {
            get { return studentRegisteredModule; }
            set
            {
                if (studentRegisteredModule != value)
                {
                    studentRegisteredModule = value;
                    //NotifyPropertyChanged("StudentRegisteredModule");
                }
            }
        }
    }
}
