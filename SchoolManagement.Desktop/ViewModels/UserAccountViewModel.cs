using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.ViewModels
{
    public class UserAccountViewModel : ViewModelBase
    {
            private string userName;

            public string UserName
            {
                get { return userName; }
                set
                {
                    if (userName != value)
                    {
                        userName = value;
                        NotifyPropertyChanged("UserName");
                    }
                }
            }

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    NotifyPropertyChanged("FullName");
                }
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    NotifyPropertyChanged("Password");
                }
            }
        }
    }
}
