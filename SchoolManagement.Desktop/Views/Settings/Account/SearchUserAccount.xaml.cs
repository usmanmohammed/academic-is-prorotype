using SchoolManagement.Data.Models;
using SchoolManagement.Desktop.ViewModels;
using Hammer.MDIContainer.Control;
using MaterialMessageBoxUtils;
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
using SchoolManagement.Data;

namespace SchoolManagement.Desktop.Views.Settings.Account
{
    /// <summary>
    /// Interaction logic for SearchUserAccount.xaml
    /// </summary>
    public partial class SearchUserAccount : UserControl
    {
        private string returnUrl;
        private List<UserAccountViewModel> temporaryUserAccountsList;
        private ObservableCollection<UserAccountViewModel> userAccountsCollection;
        public override string ToString()
        {
            return "searchUserAccount";
        }
        public SearchUserAccount(string returnUrl)
        {
            InitializeComponent();
            this.returnUrl = returnUrl;
            DataContext = userAccountsCollection = new ObservableCollection<UserAccountViewModel>();
        }
        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadProgressBar();
            using (DatabaseContext db = new DatabaseContext())
            {
                try
                {
                    var userAccounts = await db.UserAccounts.ToListAsync();
                    userAccounts.ForEach(userAccount =>
                    {
                        userAccountsCollection.Add(new UserAccountViewModel()
                        {
                            UserName = userAccount.UserName,
                            FullName = userAccount.FullName,
                            Password = userAccount.Password
                        });
                    });
                }
                catch (Exception ex)
                {
                    Helpers.WindowHelper.CatchException(ex);
                }
            }
            temporaryUserAccountsList = userAccountsCollection.ToList();
            UnloadProgressBar();
            searchBox.Focus();
        }
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception)
            {
            }
        }

        private void Search()
        {
            if (!string.IsNullOrEmpty(searchBox.Text))
            {
                string queryString = searchBox.Text.ToLower();

                var searchResults = temporaryUserAccountsList.Where(d => d.UserName.ToLower().Contains(queryString) ||
                d.FullName.ToLower().Contains(queryString)).ToList();

                userAccountsCollection.Clear();
                searchResults.ForEach(userAccount => { userAccountsCollection.Add(userAccount); });
            }
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SelectItem();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            SelectItem();
        }

        private void SelectItem()
        {
            try
            {
                var selectedUserAccount = (UserAccountViewModel)dataGrid.SelectedItem;
                App.Current.Properties["SelectedUserAccount"] = selectedUserAccount;

                MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
                container.Items.Remove((MdiWindow)this.Parent);

                if (returnUrl == "userPermissions")
                {
                    var editStaffWindow = (container.Items.OfType<MdiWindow>()).Where(r => r.Content.ToString() == returnUrl).First();
                    ((Permissions)editStaffWindow.Content).Refresh();
                    editStaffWindow.IsSelected = true;
                    editStaffWindow.Focus();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Helpers.WindowHelper.CloseWindow(this.Parent);
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
        private void btnFindUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception)
            {
            }
        }
    }
}
