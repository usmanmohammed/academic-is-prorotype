using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace EnterpriseManagement.Desktop.Converters
{
    public class SalarySelectedScheduleTypeToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                try
                {
                    string selectedItem = ((ComboBoxItem)value).Content.ToString();
                    return selectedItem == "Salary Schedule" ? Visibility.Visible : Visibility.Collapsed;
                }
                catch
                {
                    return Visibility.Collapsed;
                }
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
