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
    public class StudentToStudentTitleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value != null)
            {
                if (value is SMStudentInformation)
                {
                    SMStudentInformation student = (SMStudentInformation)value;
                    try
                    {
                        return string.IsNullOrEmpty(student.MiddleName.Trim()) ?
                            string.Format("{0} {1}", student.FirstName, student.Surname).ToUpper() :
                            string.Format("{0} {1} {2}", student.FirstName, student.MiddleName, student.Surname).ToUpper();
                    }
                    catch (Exception)
                    {
                        return "Couldn't Format " + student.StudentID;
                    }
                }

                if (value is SMPreModuleResultEntry)
                {
                    //Student Results
                    SMPreModuleResultEntry studentResult = (SMPreModuleResultEntry)value;
                    try
                    {
                        return string.IsNullOrEmpty(studentResult.MiddleName.Trim()) ?
                            string.Format("{0} {1}", studentResult.FirstName, studentResult.Surname).ToUpper() :
                            string.Format("{0} {1} {2}", studentResult.FirstName, studentResult.MiddleName, studentResult.Surname).ToUpper();
                    }
                    catch (Exception)
                    {
                        return "Couldn't Format " + studentResult.StudentID;
                    }
                }
                else
                {
                    //Student Results
                    SMStudentRegisteredModule studentsModule = (SMStudentRegisteredModule)value;
                    try
                    {
                        return string.IsNullOrEmpty(studentsModule.MiddleName.Trim()) ?
                            string.Format("{0} {1}", studentsModule.FirstName, studentsModule.Surname).ToUpper() :
                            string.Format("{0} {1} {2}", studentsModule.FirstName, studentsModule.MiddleName, studentsModule.Surname).ToUpper();
                    }
                    catch (Exception)
                    {
                        return "Couldn't Format " + studentsModule.StudentID;
                    }
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
