using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class StaffReportsViewModel : ViewModelBase
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
