using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class ViewPensionScheduleViewModel : ViewModelBase
    {
        private string reportsAndScheduleType;

        public string ReportsAndScheduleType
        {
            get { return reportsAndScheduleType; }
            set
            {
                if (reportsAndScheduleType != value)
                {
                    reportsAndScheduleType = value;
                    NotifyPropertyChanged("ReportsAndScheduleType");
                }
            }
        }

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

        private string selectedPensionAdmin;

        public string SelectedPensionAdmin
        {
            get { return selectedPensionAdmin; }
            set
            {
                if (selectedPensionAdmin != value)
                {
                    selectedPensionAdmin = value;
                    NotifyPropertyChanged("SelectedPensionAdmin");
                }
            }
        }

        private string selectedMonth;

        public string SelectedMonth
        {
            get { return selectedMonth; }
            set
            {
                if (selectedMonth != value)
                {
                    selectedMonth = value;
                    NotifyPropertyChanged("SelectedMonth");
                }
            }
        }

        private string selectedYear;

        public string SelectedYear
        {
            get { return selectedYear; }
            set
            {
                if (selectedYear != value)
                {
                    selectedYear = value;
                    NotifyPropertyChanged("SelectedYear");
                }
            }
        }

        private ObservableCollection<string> pensionAdministrators;

        public ObservableCollection<string> PensionAdministrators
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

        private ObservableCollection<string> months;

        public ObservableCollection<string> Months
        {
            get { return months; }
            set
            {
                if (months != value)
                {
                    months = value;
                    NotifyPropertyChanged("Months");
                }
            }
        }

        private ObservableCollection<string> years;

        public ObservableCollection<string> Years
        {
            get { return years; }
            set
            {
                if (years != value)
                {
                    years = value;
                    NotifyPropertyChanged("Years");
                }
            }
        }
    }
}
