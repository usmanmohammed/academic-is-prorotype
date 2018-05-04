using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EnterpriseManagement.Desktop.Converters
{
    public class GradeSettingsToRangeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                SMGradeSetting gradeSetting = (SMGradeSetting)value;
                return $"{gradeSetting.MinScore} - {gradeSetting.MaxScore}";
            }
            else
                return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
