using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EnterpriseManagement.Desktop.Converters
{
    public class IDCardStaffStudentContentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && parameter != null)
            {
                if ((string)value == "Staff")
                {
                    if ((string)parameter == "Info")
                        return "Staff Information";

                    if ((string)parameter == "Name")
                        return "Staff (Surname)";

                    if ((string)parameter == "Course/Designation")
                        return "Designation";
                }

                if ((string)value == "Student")
                {
                    if ((string)parameter == "Info")
                        return "Student Information";

                    if ((string)parameter == "Name")
                        return "Student (Surname)";

                    if ((string)parameter == "Course/Designation")
                        return "Course";
                }
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Empty;
        }
    }
}
