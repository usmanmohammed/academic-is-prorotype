using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data.Models
{
    public class LocalPermission
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public static List<LocalPermission> GetLocalPermissions()
        {
            List<LocalPermission> permissions = new List<LocalPermission>();
            permissions.Add(new LocalPermission() { Id = 10000, Description = "Students Management" });

            #region Examinations & Records
            permissions.Add(new LocalPermission() { Id = 10100, Description = "Examinations" });
            permissions.Add(new LocalPermission() { Id = 10101, Description = "Grade Settings" });
            permissions.Add(new LocalPermission() { Id = 10102, Description = "Post Students Results" });
            permissions.Add(new LocalPermission() { Id = 10103, Description = "Evaluate Students Results" });
            permissions.Add(new LocalPermission() { Id = 10104, Description = "View Students Results" });

            #endregion

            #region Students Records
            permissions.Add(new LocalPermission() { Id = 10200, Description = "Academic Management" });
            permissions.Add(new LocalPermission() { Id = 10201, Description = "Courses" });
            permissions.Add(new LocalPermission() { Id = 10202, Description = "Modules" });
            permissions.Add(new LocalPermission() { Id = 10203, Description = "Students' Information" });

            #endregion

            permissions.Add(new LocalPermission() { Id = 30000, Description = "Settings" });

            #region Account
            permissions.Add(new LocalPermission() { Id = 30100, Description = "Account Management" });
            permissions.Add(new LocalPermission() { Id = 30101, Description = "View My Account" });
            permissions.Add(new LocalPermission() { Id = 30102, Description = "Manage Other Accounts" });
            #endregion

            #region Applcation Permissions
            permissions.Add(new LocalPermission() { Id = 30200, Description = "Application Permission" });
            permissions.Add(new LocalPermission() { Id = 30201, Description = "Update User Permissions" });
            #endregion


            return permissions;
        }
    }
}
