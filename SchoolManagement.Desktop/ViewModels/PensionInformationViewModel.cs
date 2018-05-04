using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class PensionInformationViewModel : ViewModelBase
    {
        private StaffViewModel staff;

        public StaffViewModel Staff
        {
            get { return staff; }
            set
            {
                if (staff != value)
                {
                    staff = value;
                    NotifyPropertyChanged("Staff");
                }
            }
        }

        private HRPensionAdministrator selectedPensionAdministrator;

        public HRPensionAdministrator SelectedPensionAdministrator
        {
            get { return selectedPensionAdministrator; }
            set
            {
                if (selectedPensionAdministrator != value)
                {
                    selectedPensionAdministrator = value;
                    NotifyPropertyChanged("SelectedPensionAdministrator");
                }
            }
        }

        private int selectedPensionAdministratorIndex;

        public int SelectedPensionAdministratorIndex
        {
            get { return selectedPensionAdministratorIndex; }
            set
            {
                if (selectedPensionAdministratorIndex != value)
                {
                    selectedPensionAdministratorIndex = value;
                    NotifyPropertyChanged("SelectedPensionAdministratorIndex");
                }
            }
        }

        private ObservableCollection<HRPensionAdministrator> pensionAdministrators;

        public ObservableCollection<HRPensionAdministrator> PensionAdministrators
        {
            get { return pensionAdministrators; }
            set
            {
                if (pensionAdministrators != value)
                {
                    pensionAdministrators = value;
                    NotifyPropertyChanged("PensionAdministrators");
                }
            }
        }

        private HRStaffPensionRecord staffPensionInfo;

        public HRStaffPensionRecord StaffPensionInfo
        {
            get { return staffPensionInfo; }
            set
            {
                if (staffPensionInfo != value)
                {
                    staffPensionInfo = value;
                    NotifyPropertyChanged("StaffPensionInfo");
                }
            }
        }
    }
}
