using SchoolManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.ViewModels
{
    public class PermissionViewModel : ViewModelBase
    {
        private int id;

        public int Id
        {
            get { return id; }
            set {
                if (id != value)
                {
                    id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }

        private string permissionDescription;

        public string PermissionDescription
        {
            get { return permissionDescription; }
            set
            {
                if (permissionDescription != value)
                {
                    permissionDescription = value;
                    NotifyPropertyChanged("PermissionDescription");
                }
            }
        }

        private bool isEnabled;

        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    NotifyPropertyChanged("IsEnabled");
                }
            }
        }
    }
}
