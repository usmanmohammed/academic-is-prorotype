using MaterialMessageBoxUtils;
using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolManagement.Desktop
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Password))
            {
                MaterialMessageBox.Show("The fields username and password are required", "AlertCircle", MessageBoxButton.OK);
                return;
            }

            LoadProgressBar();
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Password;

            if (await Task.Run(async () => await LoginAsync(username, password)))
            {
                ((Border)this.Parent).Visibility = Visibility.Collapsed;
                passwordTextBox.Clear();
            }
            else
            {
                MaterialMessageBox.Show("Login unsuccessful! Please check your username or password. Also check your network connection and try again. If error persists, contact your IT administrator.",
                    "AlertCircle", MessageBoxButton.OK);
            }
            UnloadProgressBar();
        }

        private async Task<bool> LoginAsync(string username, string password)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                try
                {
                    string encryptedPassword = Cryptography.Encrypt(password);
                    UserAccount userAccount = await db.UserAccounts.Where(r => r.UserName.Equals(username) && r.Password.Equals(encryptedPassword)).SingleOrDefaultAsync();
                    if (userAccount != null)
                    {
                        App.Current.Properties["UserAccount"] = userAccount;
                        List<UserPermission> userPermissions = await db.UserPermissions.Where(r => r.UserName == userAccount.UserName).ToListAsync();

                        if (!userPermissions.Select(r => r.PermissionID).Contains(30000))
                            userPermissions.Add(new UserPermission() { PermissionID = 30000 });

                        if (!userPermissions.Select(r => r.PermissionID).Contains(30100))
                            userPermissions.Add(new UserPermission() { PermissionID = 30100 });

                        if (!userPermissions.Select(r => r.PermissionID).Contains(30101))
                            userPermissions.Add(new UserPermission() { PermissionID = 30101 });

                        if (userAccount.UserName.Equals("admin"))
                        {
                            if (!userPermissions.Select(r => r.PermissionID).Contains(30200))
                                userPermissions.Add(new UserPermission() { PermissionID = 30200 });

                            if (!userPermissions.Select(r => r.PermissionID).Contains(30201))
                                userPermissions.Add(new UserPermission() { PermissionID = 30201 });
                        }

                        HomeWindow homeWindow = (HomeWindow)Helpers.WindowHelper.FindWindow(this.Parent);
                        homeWindow.HomeViewModel.UserPermissions = new ObservableCollection<UserPermission>(userPermissions);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        #region Helpers
        private void LoadProgressBar()
        {
            if (loadingBar.Visibility == Visibility.Collapsed)
            {
                loadingBar.Visibility = Visibility.Visible;
            }
        }
        private void UnloadProgressBar()
        {
            if (loadingBar.Visibility == Visibility.Visible)
            {
                loadingBar.Visibility = Visibility.Collapsed;
            }
        }
        #endregion
    }
}
