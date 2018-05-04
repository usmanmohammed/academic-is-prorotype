using SchoolManagement.Data;
using SchoolManagement.Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private bool printToolsVisibility;
        public bool PrintToolsVisibility
        {
            get { return printToolsVisibility; }
            set
            {
                if (printToolsVisibility != value)
                {
                    printToolsVisibility = value;
                    NotifyPropertyChanged("PrintToolsVisibility");
                }
            }
        }

        private bool timetableToolsVisibility;
        public bool TimetableToolsVisibility
        {
            get { return timetableToolsVisibility; }
            set
            {
                if (timetableToolsVisibility != value)
                {
                    timetableToolsVisibility = value;
                    NotifyPropertyChanged("TimetableToolsVisibility");
                }
            }
        }

        private int mainMenuSelectedIndex;
        public int MainMenuSelectedIndex
        {
            get { return mainMenuSelectedIndex; }
            set
            {
                if (mainMenuSelectedIndex != value)
                {
                    mainMenuSelectedIndex = value;
                    NotifyPropertyChanged("MainMenuSelectedIndex");
                }
            }
        }

        #region Home

        private string userAccountName;
        public string UserAccountName
        {
            get { return userAccountName; }
            set
            {
                if (userAccountName != value)
                {
                    userAccountName = value;
                    NotifyPropertyChanged("UserAccountName");
                }
            }
        }

        private ObservableCollection<UserPermission> userPermissions;
        public ObservableCollection<UserPermission> UserPermissions
        {
            get { return userPermissions; }
            set
            {
                if (userPermissions != value)
                {
                    userPermissions = value;
                    NotifyPropertyChanged("UserPermissions");
                }
            }
        }

        public UserPermission this[int id]
        {
            get { return userPermissions.SingleOrDefault(r => r.PermissionID == id); }
        }
        #endregion

        #region Human Resource

        private bool humanResourceVisibility;

        public bool HumanResourceVisibility
        {
            get { return humanResourceVisibility; }
            set
            {
                if (humanResourceVisibility != value)
                {
                    humanResourceVisibility = value;
                    NotifyPropertyChanged("HumanResourceVisibility");
                }
            }
        }

        #region Staff
        private bool addStaffVisibility;

        public bool AddStaffVisibility
        {
            get { return addStaffVisibility; }
            set
            {
                if (addStaffVisibility != value)
                {
                    addStaffVisibility = value;
                    NotifyPropertyChanged("AddStaffVisibility");
                }
            }
        }

        private bool editStaffVisibility;

        public bool EditStaffVisibility
        {
            get { return editStaffVisibility; }
            set
            {
                if (editStaffVisibility != value)
                {
                    editStaffVisibility = value;
                    NotifyPropertyChanged("EditStaffVisibility");
                }
            }
        }

        private bool editGrossPayVisibility;

        public bool EditGrossPayVisibility
        {
            get { return editGrossPayVisibility; }
            set
            {
                if (editGrossPayVisibility != value)
                {
                    editGrossPayVisibility = value;
                    NotifyPropertyChanged("EditGrossPayVisibility");
                }
            }
        }


        private bool updateDeductionsVisibility;

        public bool UpdateDeductionsVisibility
        {
            get { return updateDeductionsVisibility; }
            set
            {
                if (updateDeductionsVisibility != value)
                {
                    updateDeductionsVisibility = value;
                    NotifyPropertyChanged("UpdateDeductionsVisibility");
                }
            }
        }

        private bool viewPaymentHistoryVisibility;

        public bool ViewPaymentHistoryVisibility
        {
            get { return viewPaymentHistoryVisibility; }
            set
            {
                if (viewPaymentHistoryVisibility != value)
                {
                    viewPaymentHistoryVisibility = value;
                    NotifyPropertyChanged("ViewPaymentHistoryVisibility");
                }
            }
        }
        #endregion

        #region Salary

        private bool postScheduleVisibility;

        public bool PostScheduleVisibility
        {
            get { return postScheduleVisibility; }
            set
            {
                if (postScheduleVisibility != value)
                {
                    postScheduleVisibility = value;
                    NotifyPropertyChanged("PostScheduleVisibility");
                }
            }
        }

        private bool postAllowanceDeductionVisibility;

        public bool PostAllowanceDeductionVisibility
        {
            get { return postAllowanceDeductionVisibility; }
            set
            {
                if (postAllowanceDeductionVisibility != value)
                {
                    postAllowanceDeductionVisibility = value;
                    NotifyPropertyChanged("PostAllowanceDeductionVisibility");
                }
            }
        }

        private bool viewReportsVisibility;

        public bool ViewReportsVisibility
        {
            get { return viewReportsVisibility; }
            set
            {
                if (viewReportsVisibility != value)
                {
                    viewReportsVisibility = value;
                    NotifyPropertyChanged("ViewReportsVisibility");
                }
            }
        }


        #endregion

        #region Pension

        private bool viewAnalysisVisibility;

        public bool ViewAnalysisVisibility
        {
            get { return viewAnalysisVisibility; }
            set
            {
                if (viewAnalysisVisibility != value)
                {
                    viewAnalysisVisibility = value;
                    NotifyPropertyChanged("ViewAnalysisVisibility");
                }
            }
        }

        #endregion

        #endregion

        #region Settings

        private bool settingsVisibility;

        public bool SettingsVisibility
        {
            get { return settingsVisibility; }
            set
            {
                if (settingsVisibility != value)
                {
                    settingsVisibility = value;
                    NotifyPropertyChanged("SettingsVisibility");
                }
            }
        }

        #region Account

        private bool userAccountVisibility;

        public bool UserAccountVisibility
        {
            get { return userAccountVisibility; }
            set
            {
                if (userAccountVisibility != value)
                {
                    userAccountVisibility = value;
                    NotifyPropertyChanged("UserAccountVisibility");
                }
            }
        }

        private bool updatePermissionsVisibility;

        public bool UpdatePermissionsVisibility
        {
            get { return updatePermissionsVisibility; }
            set
            {
                if (updatePermissionsVisibility != value)
                {
                    updatePermissionsVisibility = value;
                    NotifyPropertyChanged("UpdatePermissionsVisibility");
                }
            }
        }

        #endregion

        #endregion

        private RelayCommand signoutCommand;
        public RelayCommand SignoutCommand
        {
            get { return signoutCommand; }
            set
            {
                if (signoutCommand != value)
                {
                    signoutCommand = value;
                    NotifyPropertyChanged("SignoutCommand");
                }
            }
        }

        private RelayCommand printCommand;
        public RelayCommand PrintCommand
        {
            get { return printCommand; }
            set
            {
                if (printCommand != value)
                {
                    printCommand = value;
                    NotifyPropertyChanged("PrintCommand");
                }
            }
        }

        private RelayCommand exportCommand;
        public RelayCommand ExportCommand
        {
            get { return exportCommand; }
            set
            {
                if (exportCommand != value)
                {
                    exportCommand = value;
                    NotifyPropertyChanged("ExportCommand");
                }
            }
        }
    }
}
