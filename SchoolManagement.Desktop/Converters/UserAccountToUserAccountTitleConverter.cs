using SchoolManagement.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SchoolManagement.Desktop.Converters
{
    public class UserAccountToUserAccountTitleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                UserAccountViewModel userAccount = (UserAccountViewModel)value;
                try
                {
                    return string.Format("{0} ({1})", userAccount.FullName, userAccount.UserName);
                }
                catch (Exception)
                {
                    return "Couldn't Format " + userAccount.UserName;
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
