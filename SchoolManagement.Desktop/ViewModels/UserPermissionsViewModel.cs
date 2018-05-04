using SchoolManagement.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.ViewModels
{
    public class UserPermissionsViewModel : ViewModelBase
    {
        private UserAccountViewModel userAccount;

        public UserAccountViewModel UserAccount
        {
            get { return userAccount; }
            set
            {
                if (userAccount != value)
                {
                    userAccount = value;
                    NotifyPropertyChanged("UserAccount");
                }
            }
        }

        private ObservableCollection<IPermissionViewModel> userPermissions;

        public ObservableCollection<IPermissionViewModel> UserPermissions
        {
            get { return userPermissions; }
            set
            {
                if (userPermissions != value)
                {
                    userPermissions = value;
                    NotifyPropertyChanged("UserPermissions");
                }
            }
        }
    }
}
