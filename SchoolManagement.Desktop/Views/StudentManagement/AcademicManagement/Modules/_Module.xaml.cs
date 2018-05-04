using Hammer.MDIContainer.Control;
using MaterialMessageBoxUtils;
using SchoolManagement.Data;
using SchoolManagement.Desktop.ViewModels;
using SchoolManagement.Desktop.Views.StudentsManagement.Courses;
using StudentManagement.Desktop.ViewModels;
using System;
using System.Collections.Generic;
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

namespace SchoolManagement.Desktop.Views.StudentManagement.AcademicManagement.Modules
{
    /// <summary>
    /// Interaction logic for Module.xaml
    /// </summary>
    public partial class _Module : UserControl
    {
        private string windowTitle;
        private string addTitle = "Add Module";
        private string editTitle = "Edit Module";

        private ModuleViewModel moduleViewModel;
        private UserAccount currentUser;

        public override string ToString() => "module";

        public _Module(string windowTitle, Module module)
        {
            InitializeComponent();
            currentUser = (UserAccount)App.Current.Properties["UserAccount"];

            if (windowTitle == addTitle)
            {
                DataContext = moduleViewModel = new ModuleViewModel() { Module = new Module() };
            }
            if (windowTitle == editTitle)
            {
                DataContext = moduleViewModel = new ModuleViewModel() { Module = module};
            }
            this.windowTitle = windowTitle;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Helpers.WindowHelper.CloseWindow(this.Parent);
        }

        private void btnSearchCourse_Click(object sender, RoutedEventArgs e)
        {
            MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
            MdiWindow item = new MdiWindow
            {
                Title = "Find Course",
                CanClose = true,
                Height = 530,
                Width = 900,
                IsResizable = true,
                IsModal = false,
                Content = new SearchCourse(this.ToString()),
                WindowID = "FindCourse",
                ParentTitle = ((MdiWindow)this.Parent).Title,
                ParentSelectedIndex = ((MdiWindow)this.Parent).ParentSelectedIndex
            };
            item.Closing += (s, f) => container.Items.Remove(item);
            container.Items.Add(item);
        }

        public void Refresh()
        {
            if (App.Current.Properties["SelectedCourse"] != null)
            {
                moduleViewModel.Module.Course = (Course)App.Current.Properties["SelectedCourse"];
                App.Current.Properties["SelectedCourse"] = null;
            }
        }

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (ValidationErrorsExist())
                return;

            if (windowTitle == addTitle)
            {
                BindingOperations.GetBindingExpression(moduleCodeTextBox, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(moduleDescriptionTextBox, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(courseTextBox, TextBox.TextProperty).UpdateSource();

                using (DatabaseContext db = new DatabaseContext())
                {
                    try
                    {
                        moduleViewModel.Module.CreatedBy = currentUser.UserName;
                        moduleViewModel.Module.DateCreated = DateTime.UtcNow.AddHours(1);
                        moduleViewModel.Module.UpdatedBy = currentUser.UserName;
                        moduleViewModel.Module.DateUpdated = DateTime.UtcNow.AddHours(1);

                        db.Modules.Add(moduleViewModel.Module);
                        await db.SaveChangesAsync();
                        MaterialMessageBox.Show("Record successfully added", "CheckCircle", MessageBoxButton.OK);
                    }
                    catch (Exception ex)
                    {
                        Helpers.WindowHelper.CatchException(ex);
                    }
                }

                MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
                var modulesWindow = (container.Items.OfType<MdiWindow>()).Where(r => r.Content.GetType() == typeof(Modules)).First();
                await ((Modules)modulesWindow.Content).LoadItems();
            }
            if (windowTitle == editTitle)
            {
                moduleViewModel.Module.ModuleCode = moduleCodeTextBox.Text;
                moduleViewModel.Module.ModuleDescription = moduleDescriptionTextBox.Text;
                moduleViewModel.Module.CourseID = moduleViewModel.Module.Course.CourseID;

                using (DatabaseContext db = new DatabaseContext())
                {
                    try
                    {
                        moduleViewModel.Module.UpdatedBy = currentUser.UserName;
                        moduleViewModel.Module.DateUpdated = DateTime.UtcNow.AddHours(1);

                        db.Entry(moduleViewModel.Module).State = System.Data.Entity.EntityState.Modified;
                        await db.SaveChangesAsync();
                        MaterialMessageBox.Show("Record successfully updated", "CheckCircle", MessageBoxButton.OK);

                    }
                    catch (Exception ex)
                    {
                        Helpers.WindowHelper.CatchException(ex);
                    }
                }

                BindingOperations.GetBindingExpression(moduleCodeTextBox, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(moduleDescriptionTextBox, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(courseTextBox, TextBox.TextProperty).UpdateSource();
            }
        }

        private bool ValidationErrorsExist()
        {
            if (string.IsNullOrEmpty(moduleCodeTextBox.Text) || string.IsNullOrWhiteSpace(moduleCodeTextBox.Text))
            {
                MaterialMessageBox.Show("Please review the field 'Module Code'. Field cannot be empty.", "InformationOutline", MessageBoxButton.OK);
                return true;
            }
            else if (string.IsNullOrEmpty(moduleDescriptionTextBox.Text) || string.IsNullOrWhiteSpace(moduleDescriptionTextBox.Text))
            {
                MaterialMessageBox.Show("Please review the field 'Module Description'. Field cannot be empty.", "InformationOutline", MessageBoxButton.OK);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}