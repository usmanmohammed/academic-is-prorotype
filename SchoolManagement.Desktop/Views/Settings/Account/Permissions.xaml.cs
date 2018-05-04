using SchoolManagement.Data.Models;
using SchoolManagement.Desktop.Helpers;
using SchoolManagement.Desktop.ViewModels;
using Hammer.MDIContainer.Control;
using MaterialMessageBoxUtils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using SchoolManagement.Desktop.ViewModels;

namespace SchoolManagement.Desktop.Views.Settings.Account
{
    /// <summary>
    /// Interaction logic for Permissions.xaml
    /// </summary>
    public partial class Permissions : UserControl
    {
        private UserPermissionsViewModel userPermissionsViewModel;
        private UserAccount currentUser;

        public override string ToString()
        {
            return "userPermissions";
        }
        public Permissions()
        {
            InitializeComponent();
            DataContext = userPermissionsViewModel = new UserPermissionsViewModel();

            currentUser = (UserAccount)App.Current.Properties["UserAccount"];
        }

        private void btnSearchUser_Click(object sender, RoutedEventArgs e)
        {
            MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
            MdiWindow item = new MdiWindow
            {
                Title = "Find User Account",
                CanClose = true,
                Height = 530,
                Width = 900,
                IsResizable = true,
                IsModal = false,
                Content = new SearchUserAccount(this.ToString()),
                WindowID = "FindUserAccount",
                ParentTitle = ((MdiWindow)this.Parent).Title,
                ParentSelectedIndex = ((MdiWindow)this.Parent).ParentSelectedIndex
            };
            item.Closing += (s, f) => container.Items.Remove(item);
            container.Items.Add(item);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Helpers.WindowHelper.CloseWindow(this.Parent);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Validate
            using (DatabaseContext db = new DatabaseContext())
            {
                try
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            IEnumerable<UserPermission> usersOldPermissions = db.UserPermissions.Where(r => r.UserName == userPermissionsViewModel.UserAccount.UserName);
                            db.UserPermissions.RemoveRange(usersOldPermissions);
                            db.SaveChanges();

                            userPermissionsViewModel.UserPermissions.Flatten(r => r.Children).Where(r => r.IsChecked).ToList().ForEach(permission =>
                            {
                                db.UserPermissions.Add(new UserPermission()
                                {
                                    UserName = userPermissionsViewModel.UserAccount.UserName,
                                    PermissionID = permission.Id,
                                    PermissionDescription = permission.Title,
                                    CreatedBy = currentUser.UserName,
                                    DateCreated = DateTime.UtcNow.AddHours(1),
                                    UpdatedBy = currentUser.UserName,
                                    DateUpdated = DateTime.UtcNow.AddHours(1)
                                });
                            });
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            MaterialMessageBox.Show("User Permissions Successfully Updated", "CheckCircle", MessageBoxButton.OK);
                        }
                        catch (Exception)
                        {
                            dbContextTransaction.Rollback();
                            MaterialMessageBox.Show("An error has occured! Please try again or contact your IT administrator if error persists.", "AlertCircle", MessageBoxButton.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Helpers.WindowHelper.CatchException(ex);
                }
            }
        }

        public void Refresh()
        {
            if (App.Current.Properties["SelectedUserAccount"] != null)
            {
                var tempUserPermissions = new ObservableCollection<PermissionViewModel>();

                userPermissionsViewModel.UserAccount = ((UserAccountViewModel)App.Current.Properties["SelectedUserAccount"]);
                userPermissionsViewModel.UserPermissions = new ObservableCollection<IPermissionViewModel>();

                App.Current.Properties["SelectedUserAccount"] = null;
                using (DatabaseContext db = new DatabaseContext())
                {
                    try
                    {
                        List<UserPermission> userPermissions = db.UserPermissions.Where(r => r.UserName == userPermissionsViewModel.UserAccount.UserName).ToList();
                        LocalPermission.GetLocalPermissions().ForEach(localPermission =>
                        {
                            if (userPermissions.Select(r => r.PermissionID).Contains(localPermission.Id))
                            {
                                tempUserPermissions.Add(new PermissionViewModel()
                                {
                                    IsEnabled = true,
                                    Id = localPermission.Id,
                                    PermissionDescription = localPermission.Description
                                });
                            }
                            else
                            {
                                tempUserPermissions.Add(new PermissionViewModel()
                                {
                                    IsEnabled = false,
                                    Id = localPermission.Id,
                                    PermissionDescription = localPermission.Description
                                });
                            }
                        });
                    }
                    catch (Exception ex)
                    {
                        Helpers.WindowHelper.CatchException(ex);
                    }
                }
                for (int i = 1; i < 10; i++)
                {
                    var menu = tempUserPermissions.SingleOrDefault(r => r.Id.Equals(i * 10000));
                    if (menu != null)
                    {
                        var permission = new IPermissionViewModel()
                        {
                            Title = menu.PermissionDescription,
                            Id = menu.Id,
                            IsChecked = menu.IsEnabled,
                            Children = new ObservableCollection<IPermissionViewModel>()
                        };
                        for (int j = 1; j < 100; j++)
                        {
                            var submenu = tempUserPermissions.SingleOrDefault(r => r.Id.Equals((i * 10000) + (j * 100)));
                            if (submenu != null)
                            {
                                var subpermission = new IPermissionViewModel()
                                {
                                    Id = submenu.Id,
                                    Title = submenu.PermissionDescription,
                                    IsChecked = submenu.IsEnabled,
                                    Parent  = permission,
                                    Children = new ObservableCollection<IPermissionViewModel>()
                                };
                                for (int k = 1; k < 100; k++)
                                {
                                    var subitem = tempUserPermissions.SingleOrDefault(r => r.Id.Equals((i * 10000) + (j * 100) + k));
                                    if (subitem != null)
                                    {
                                        var itempermission = new IPermissionViewModel()
                                        {
                                            Id = subitem.Id,
                                            Title = subitem.PermissionDescription,
                                            IsChecked = subitem.IsEnabled,
                                            Parent = subpermission,
                                            Children = new ObservableCollection<IPermissionViewModel>()
                                        };
                                        subpermission.Children.Add(itempermission);
                                    }
                                }
                                permission.Children.Add(subpermission);
                            }
                        }
                        userPermissionsViewModel.UserPermissions.Add(permission);
                    }
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Changed(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                var selectedItem = (CheckBox)sender;
                var selectedPermission = userPermissionsViewModel.UserPermissions.Flatten(r => r.Children).SingleOrDefault(f => f.Title.Equals(selectedItem.Content));
                if (selectedItem != null)
                {
                    selectedPermission.IsChecked = selectedItem.IsChecked.GetValueOrDefault();
                    CheckChildren(selectedPermission, selectedPermission.IsChecked);
                }
            }

        }

        private void CheckChildren(IPermissionViewModel selectedPermission, bool isChecked)
        {
            foreach (var item in selectedPermission.Children)
            {
                item.IsChecked = isChecked;
                CheckChildren(item, item.IsChecked);
            }
        }
    }
}
