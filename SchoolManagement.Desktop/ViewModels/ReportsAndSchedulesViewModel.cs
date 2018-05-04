using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class ReportsAndSchedulesViewModel : ViewModelBase
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


        private string selectedSalaryScheduleType;

        public string SelectedSalaryScheduleType
        {
            get { return selectedSalaryScheduleType; }
            set
            {
                if (selectedSalaryScheduleType != value)
                {
                    selectedSalaryScheduleType = value;
                    NotifyPropertyChanged("SelectedSalaryScheduleType");
                }
            }
        }

        private DateTime selectedDate;

        public DateTime SelectedDate
        {
            get { return selectedDate; }
            set
            {
                if (selectedDate != value)
                {
                    selectedDate = value;
                    NotifyPropertyChanged("SelectedDate");
                }
            }
        }
    }
}
