using Hammer.MDIContainer.Control;
using SchoolManagement.Data;
using SchoolManagement.Desktop.Helpers;
using SchoolManagement.Desktop.ViewModels;
using SchoolManagement.Desktop.Views.Settings.Account;
using SchoolManagement.Desktop.Views.StudentManagement.AcademicManagement.Courses;
using SchoolManagement.Desktop.Views.StudentManagement.AcademicManagement.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        private string previousWindowID;

        private HomeViewModel homeViewModel;
        public HomeViewModel HomeViewModel
        {
            get { return homeViewModel; }
            set { homeViewModel = value; }
        }

        public KeyValuePair<string, object> _printTools = new KeyValuePair<string, object>("PrintTools", true);
        public KeyValuePair<string, object> _timetableTools = new KeyValuePair<string, object>("TimetableTools", true);
        public KeyValuePair<string, object> _generalTools = new KeyValuePair<string, object>("GeneralTools", true);

        [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("6d5140c1-7436-11ce-8034-00aa006009fa")]
        internal interface IServiceProvider
        {
            [return: MarshalAs(UnmanagedType.IUnknown)]
            object QueryService(ref Guid guidService, ref Guid riid);
        }

        private static readonly Guid SID_SWebBrowserApp = new Guid("0002DF05-0000-0000-C000-000000000046");

        public HomeWindow()
        {
            InitializeComponent();
            homeViewModel = new HomeViewModel()
            {
                MainMenuSelectedIndex = -1,
                PrintToolsVisibility = false,
                TimetableToolsVisibility = false,
                SignoutCommand = new RelayCommand(new Action<object>(SignoutCommand)),
                PrintCommand = new RelayCommand(new Action<object>(PrintCommand)),
                ExportCommand = new RelayCommand(new Action<object>(ExportCommand))
            };
            DataContext = homeViewModel;
            ((Login)loginOverlay.Child).usernameTextBox.Focus();
        }

        private void SignoutCommand(object sender)
        {
            SignOut();
        }

        private void PrintCommand(object sender)
        {
            PrintWindow();
        }

        private async void ExportCommand(object sender)
        {
            //await ExportFile();
        }

        public void CollapseAllMenuToolBars()
        {
            homeViewModel.TimetableToolsVisibility = false;
            homeViewModel.PrintToolsVisibility = false;
        }

        private void TreeViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string mainMenuItemTitle = ((TextBlock)((StackPanel)((StackPanel)((ListBoxItem)mainMenuItemsList.SelectedItem).Content).Children[1]).Children[0]).Text;
            string commandSource = ((TreeViewItem)sender).Header.ToString();

            #region Students Management

            if (mainMenuItemTitle == "Students Management")
            {
                #region Academic Management

                if (commandSource == "Courses")
                {
                    MdiWindow item = new MdiWindow
                    {
                        Title = commandSource,
                        CanClose = true,
                        IsResizable = false,
                        IsModal = false,
                        Height = 530,
                        Width = 900,
                        Content = new Courses(),
                        WindowID = commandSource,
                        ParentTitle = mainMenuItemTitle,
                        ParentSelectedIndex = mainMenuItemsList.SelectedIndex
                    };
                    if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
                        UpdateContainer(item);
                }

                if (commandSource == "Modules")
                {
                    MdiWindow item = new MdiWindow
                    {
                        Title = commandSource,
                        CanClose = true,
                        Height = 530,
                        Width = 900,
                        IsResizable = true,
                        IsModal = false,
                        Content = new Modules(),
                        WindowID = commandSource,
                        ParentTitle = mainMenuItemTitle,
                        ParentSelectedIndex = mainMenuItemsList.SelectedIndex
                    };
                    if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
                        UpdateContainer(item);
                }

                if (commandSource == "Students")
                {
                    MdiWindow item = new MdiWindow
                    {
                        Title = commandSource,
                        CanClose = true,
                        IsResizable = false,
                        IsModal = false,
                        //Content = new Students(),
                        WindowID = commandSource,
                        ParentTitle = mainMenuItemTitle,
                        ParentSelectedIndex = mainMenuItemsList.SelectedIndex
                    };
                    if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
                        UpdateContainer(item);
                }



                #endregion
            }

            #endregion

            /*
#region HR

if (mainMenuItemTitle == "Human Resource")
{
    #region Staff Management
    if (commandSource == "Add Staff")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            Height = 530,
            Width = 900,
            IsResizable = true,
            IsModal = false,
            Content = new AddStaff(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex,
            //AdditionalProperties = new List<KeyValuePair<string, object>>() { _printTools, _timetableTools }
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Edit Staff")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            Height = 530,
            Width = 900,
            IsResizable = true,
            IsModal = false,
            Content = new EditStaff(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Edit Gross Pay")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Content = new EditStaffGrossPay(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Edit Pension Info")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Content = new EditPensionInformation(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Update Deductions")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            Height = 530,
            Width = 900,
            IsResizable = true,
            IsModal = false,
            Content = new ViewDeductions(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "View Payment History")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            Height = 530,
            Width = 900,
            IsResizable = true,
            IsModal = false,
            Content = new PaymentHistory(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "View Reports")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Content = new StaffReports(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    #endregion

    #region Salary Management
    if (commandSource == "Post Schedule")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Content = new PostSchedule(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Post Allowance & Deduction")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Content = new AllowanceAndDeduction(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "View Reports & Schedules")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Content = new ReportsAndSchedules(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    #endregion

    #region Pension
    if (commandSource == "View Analysis")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Content = new PensionAnalysis(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "View Pension Reports")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Content = new ViewPensionSchedule(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Pension Administrators")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new PensionAdministrators(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    #endregion

    #region Others
    if (commandSource == "Titles")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new Titles(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Genders")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new Genders(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Marital Statuses")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new MaritalStatuses(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Courses")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new Courses(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Staff Types")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new StaffTypes(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Designations")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new Designations(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Departments")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new Departments(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Courses")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new Courses(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Course Account Types")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new CourseAccountTypes(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Relationships")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new Relationships(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Qualifications")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new Qualifications(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    if (commandSource == "Deduction Frequencies")
    {
        MdiWindow item = new MdiWindow
        {
            Title = commandSource,
            CanClose = true,
            IsResizable = false,
            IsModal = false,
            Height = 530,
            Width = 900,
            Content = new DeductionFrequencies(),
            WindowID = commandSource,
            ParentTitle = mainMenuItemTitle,
            ParentSelectedIndex = mainMenuItemsList.SelectedIndex
        };
        if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
            UpdateContainer(item);
    }
    #endregion
}
#endregion


*/

            #region Settings
            if (mainMenuItemTitle == "Settings")
            {
                if (commandSource == "My Account")
                {
                    MdiWindow item = new MdiWindow
                    {
                        Title = "Change This",
                        CanClose = true,
                        Height = 500,
                        Width = 810,
                        IsResizable = true,
                        IsModal = false,
                        Content = new ViewAccount(),
                        WindowID = commandSource,
                        ParentTitle = mainMenuItemTitle,
                        ParentSelectedIndex = mainMenuItemsList.SelectedIndex
                    };
                    if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
                        UpdateContainer(item);
                }
                if (commandSource == "Manage Other Accounts")
                {
                    MdiWindow item = new MdiWindow
                    {
                        Title = "Change This",
                        CanClose = true,
                        Height = 500,
                        Width = 810,
                        IsResizable = true,
                        IsModal = false,
                        Content = new ViewAccount(),
                        WindowID = commandSource,
                        ParentTitle = mainMenuItemTitle,
                        ParentSelectedIndex = mainMenuItemsList.SelectedIndex
                    };
                    if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
                        UpdateContainer(item);
                }
                if (commandSource == "Update User Permissions")
                {
                    MdiWindow item = new MdiWindow
                    {
                        Title = "Change This",
                        CanClose = true,
                        Height = 530,
                        Width = 900,
                        IsResizable = true,
                        IsModal = false,
                        Content = new Permissions(),
                        WindowID = commandSource,
                        ParentTitle = mainMenuItemTitle,
                        ParentSelectedIndex = mainMenuItemsList.SelectedIndex
                    };
                    if (!Helpers.WindowHelper.CheckRestoreExistingWindow(item, Container))
                        UpdateContainer(item);
                }
            }
            #endregion
        }

        private void UpdateContainer(MdiWindow item)
        {
            item.Closing += (s, f) => { Container.Items.Remove(item); CollapseAllMenuToolBars(); };
            Container.Items.Add(item);
        }

        private void Container_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedWindow = ((MdiContainer)sender).SelectedItem;
            if (selectedWindow != null)
            {
                var mdiWindow = (MdiWindow)selectedWindow;
                if (!string.IsNullOrEmpty(previousWindowID))
                {
                    if (previousWindowID != mdiWindow.WindowID)
                    {
                        previousWindowID = mdiWindow.WindowID;
                        ShowMenuToolBars(mdiWindow);
                    }
                }
                else
                {
                    previousWindowID = mdiWindow.WindowID;
                    ShowMenuToolBars(mdiWindow);
                }
            }
        }

        private void ShowMenuToolBars(MdiWindow mdiWindow)
        {
            CollapseAllMenuToolBars();
            UpdateMainMenuSelectedItem(mdiWindow);

            if (mdiWindow.AdditionalProperties != null)
            {
                if (mdiWindow.AdditionalProperties.Select(r => r.Key).Contains("PrintTools"))
                    homeViewModel.PrintToolsVisibility = true;

                if (mdiWindow.AdditionalProperties.Select(r => r.Key).Contains("TimetableTools"))
                    homeViewModel.TimetableToolsVisibility = true;
            }
        }

        private void UpdateMainMenuSelectedItem(MdiWindow mdiWindow)
        {
            homeViewModel.MainMenuSelectedIndex = mdiWindow.ParentSelectedIndex;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintWindow();
        }

        private void PrintWindow()
        {
            //try
            //{
            //    MdiWindow printWindow = Container.Items.OfType<MdiWindow>().Where(r => r.WindowID == "Print Preview" && r.IsSelected).FirstOrDefault();
            //    if (printWindow != null)
            //    {
            //        var webBrowser = ((WebBrowser)((PrintPreview)printWindow.Content).FindName("printHelper"));

            //        IServiceProvider serviceProvider = null;
            //        if (webBrowser.Document != null)
            //        {
            //            serviceProvider = (IServiceProvider)webBrowser.Document;
            //        }

            //        Guid serviceGuid = SID_SWebBrowserApp;
            //        Guid iid = typeof(SHDocVw.IWebBrowser2).GUID;

            //        object NullValue = null;

            //        SHDocVw.IWebBrowser2 target = (SHDocVw.IWebBrowser2)serviceProvider.QueryService(ref serviceGuid, ref iid);
            //        target.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINTPREVIEW, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref NullValue, ref NullValue);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Helpers.WindowHelper.CatchException(ex);
            //}
        }

        private void SignOut()
        {
            if (loginOverlay.Visibility == Visibility.Collapsed)
            {
                loginOverlay.Visibility = Visibility.Visible;
                App.Current.Properties["UserAccount"] = null;

                Container.Items.Clear();
                ((Login)loginOverlay.Child).usernameTextBox.Focus();
            }
        }

        private void loginOverlay_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (loginOverlay.Visibility == Visibility.Collapsed)
                homeViewModel.UserAccountName = ((UserAccount)App.Current.Properties["UserAccount"]).FullName;
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            SignOut();
        }

        private void btnExitApp_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private async void btnExport_Click(object sender, RoutedEventArgs e)
        {
            //await ExportFile();
        }

        //private async Task ExportFile()
        //{
        //    try
        //    {
        //        Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog()
        //        {
        //            Filter = "PDF File|.pdf|Excel File|.xls",
        //            FileName = $"Print Preview {DateTime.Now.ToString("dd-MM-yyyy")}"
        //        };
        //        var result = dialog.ShowDialog();
        //        if (result ?? true)
        //        {
        //            string fileName = dialog.FileName;

        //            MdiWindow printWindow = Container.Items.OfType<MdiWindow>().Where(r => r.WindowID == "Print Preview").First();
        //            var webBrowser = ((IWebBrowser)((PrintPreview)printWindow.Content).FindName("printPreview"));

        //            //TODO: If PDF File Selected, Save as PDF
        //            if (dialog.FilterIndex == 1)
        //            {
        //                var success = await webBrowser.PrintToPdfAsync(dialog.FileName, new PdfPrintSettings
        //                {
        //                    MarginType = CefPdfPrintMarginType.Custom,
        //                    MarginBottom = 20,
        //                    MarginTop = 20,
        //                    MarginLeft = 20,
        //                    MarginRight = 20
        //                });

        //                if (success)
        //                    MaterialMessageBox.Show("PDF File Successfully Saved to: " + dialog.FileName, "CheckCircle", MessageBoxButton.OK);
        //                else
        //                    MaterialMessageBox.Show("PDF File Export Failed", "CloseCircle", MessageBoxButton.OK);
        //            }
        //            if (dialog.FilterIndex == 2)
        //            {
        //                try
        //                {
        //                    string applicationDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //                    string fileUrl = string.Format("{0}\\Baze University\\Shared\\PrintPreview.html", applicationDirectory);

        //                    File.WriteAllBytes(dialog.FileName, File.ReadAllBytes(fileUrl));
        //                    MaterialMessageBox.Show("Excel File Successfully Saved to: " + dialog.FileName, "CheckCircle", MessageBoxButton.OK);
        //                }
        //                catch
        //                {
        //                    MaterialMessageBox.Show("Excel File Export Failed", "CloseCircle", MessageBoxButton.OK);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Helpers.WindowHelper.CatchException(ex);
        //    }
        //}

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
