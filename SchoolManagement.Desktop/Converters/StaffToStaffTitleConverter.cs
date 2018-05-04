using EnterpriseManagement.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EnterpriseManagement.Desktop.Converters
{
    public class StaffToStaffTitleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                StaffViewModel staff = (StaffViewModel)value;
                try
                {
                    return string.IsNullOrEmpty(staff.OtherNames.Trim()) ?
                        string.Format("{0} {1} ({2})", staff.Surname, staff.FirstName, staff.StaffID) :
                        string.Format("{0} {1} {2} ({3})", staff.Surname, staff.FirstName, staff.OtherNames, staff.StaffID);
                }
                catch (Exception)
                {
                    return "Couldn't Format " + staff.StaffID;
                }
            }
            else
            {
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
