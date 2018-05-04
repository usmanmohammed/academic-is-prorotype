using EnterpriseManagement.Data.Models;
using EnterpriseManagement.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.Helpers
{
    public class StaffHelper
    {
        public static string GetStaffFullName(HRStaffDetail staffDetail)
        {
            try
            {
                return string.Format("{0} {1} {2}", staffDetail.Surname, staffDetail.FirstName, staffDetail.OtherNames);
            }
            catch (Exception)
            {
                return string.Format("{0} {1}", staffDetail.Surname, staffDetail.FirstName);
            }
        }

        public static string GetStaffFullName(StaffViewModel staffDetail)
        {
            try
            {
                return string.Format("{0} {1} {2}", staffDetail.Surname, staffDetail.FirstName, staffDetail.OtherNames);
            }
            catch (Exception)
            {
                return string.Format("{0} {1}", staffDetail.Surname, staffDetail.FirstName);
            }
        }
    }

    public class StudentHelper
    {
        public static string GetStudentFullName(SMPreModuleResultEntry studentInformation)
        {
            try
            {
                return string.Format("{0} {1} {2}", studentInformation.FirstName != null ? FirstLetterUpperCase(studentInformation.FirstName) : string.Empty,
                    studentInformation.MiddleName != null ? FirstLetterUpperCase(studentInformation.MiddleName) : string.Empty,
                    studentInformation.Surname != null ? FirstLetterUpperCase(studentInformation.Surname) : string.Empty);
            }
            catch (Exception)
            {
                return string.Format("{0} {1}", studentInformation.FirstName.ToUpper(), studentInformation.Surname.ToUpper());
            }
        }

        public static string GetStudentFullName(SMStudentInformation studentInformation)
        {
            try
            {
                return string.Format("{0} {1} {2}", studentInformation.FirstName != null ? FirstLetterUpperCase(studentInformation.FirstName) : string.Empty,
                    studentInformation.MiddleName != null ? FirstLetterUpperCase(studentInformation.MiddleName) : string.Empty,
                    studentInformation.Surname != null ? FirstLetterUpperCase(studentInformation.Surname) : string.Empty);
            }
            catch (Exception)
            {
                return string.Format("{0} {1}", studentInformation.FirstName.ToUpper(), studentInformation.Surname.ToUpper());
            }
        }

        public static string FirstLetterUpperCase(string input)
        {
            if (input.Length > 1)
                return input.First().ToString().ToUpper() + input.Substring(1).ToLower();
            else
                return input.ToUpper();
        }
    }
}
