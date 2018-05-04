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
    public class GeneralLedgerAccountTitleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                try
                {
                    GeneralLedgerAccount generalLedgerAccount = (GeneralLedgerAccount)value;
                    return string.Format("{0} ({1})", generalLedgerAccount.Description, generalLedgerAccount.AccountNumber);
                }
                catch (Exception)
                {
                    return "Couldn't Convert Ledger Account";
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
