using Hammer.MDIContainer.Control;
using MaterialMessageBoxUtils;
using SchoolManagement.Data;
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

namespace SchoolManagement.Desktop.Views.StudentManagement.AcademicManagement.Courses
{
    /// <summary>
    /// Interaction logic for Course.xaml
    /// </summary>
    public partial class _Course : UserControl
    {
        private string windowTitle;
        private string addTitle = "Add Course";
        private string editTitle = "Edit Course";

        private CourseViewModel courseViewModel;
        private UserAccount currentUser;

        public _Course(string windowTitle, Course course)
        {
            InitializeComponent();
            currentUser = (UserAccount)App.Current.Properties["UserAccount"];

            if (windowTitle == addTitle)
            {
                DataContext = courseViewModel = new CourseViewModel() { Course = new Course() };
            }
            if (windowTitle == editTitle)
            {
                DataContext = courseViewModel = new CourseViewModel() { Course = course };
            }
            this.windowTitle = windowTitle;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Helpers.WindowHelper.CloseWindow(this.Parent);
        }

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (ValidationErrorsExist())
                return;

            if (windowTitle == addTitle)
            {
                BindingOperations.GetBindingExpression(courseCodeTextBox, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(courseDescriptionTextBox, TextBox.TextProperty).UpdateSource();

                using (DatabaseContext db = new DatabaseContext())
                {
                    try
                    {
                        courseViewModel.Course.CreatedBy = currentUser.UserName;
                        courseViewModel.Course.DateCreated = DateTime.UtcNow.AddHours(1);
                        courseViewModel.Course.UpdatedBy = currentUser.UserName;
                        courseViewModel.Course.DateUpdated = DateTime.UtcNow.AddHours(1);

                        db.Courses.Add(courseViewModel.Course);
                        await db.SaveChangesAsync();
                        MaterialMessageBox.Show("Record successfully added", "CheckCircle", MessageBoxButton.OK);
                    }
                    catch (Exception ex)
                    {
                        Helpers.WindowHelper.CatchException(ex);
                    }
                }

                MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
                var coursesWindow = (container.Items.OfType<MdiWindow>()).Where(r => r.Content.GetType() == typeof(Courses)).First();
                await ((Courses)coursesWindow.Content).LoadItems();
            }
            if (windowTitle == editTitle)
            {
                courseViewModel.Course.CourseCode = courseCodeTextBox.Text;
                courseViewModel.Course.CourseDescription = courseDescriptionTextBox.Text;

                using (DatabaseContext db = new DatabaseContext())
                {
                    try
                    {
                        courseViewModel.Course.UpdatedBy = currentUser.UserName;
                        courseViewModel.Course.DateUpdated = DateTime.UtcNow.AddHours(1);

                        db.Entry(courseViewModel.Course).State = System.Data.Entity.EntityState.Modified;
                        await db.SaveChangesAsync();
                        MaterialMessageBox.Show("Record successfully updated", "CheckCircle", MessageBoxButton.OK);

                    }
                    catch (Exception ex)
                    {
                        Helpers.WindowHelper.CatchException(ex);
                    }
                }

                BindingOperations.GetBindingExpression(courseCodeTextBox, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(courseDescriptionTextBox, TextBox.TextProperty).UpdateSource();
            }
        }

        private bool ValidationErrorsExist()
        {
            if (string.IsNullOrEmpty(courseCodeTextBox.Text) || string.IsNullOrWhiteSpace(courseCodeTextBox.Text))
            {
                MaterialMessageBox.Show("Please review the field 'Course Code'. Field cannot be empty.", "InformationOutline", MessageBoxButton.OK);
                return true;
            }
            else if (string.IsNullOrEmpty(courseDescriptionTextBox.Text) || string.IsNullOrWhiteSpace(courseDescriptionTextBox.Text))
            {
                MaterialMessageBox.Show("Please review the field 'Course Description'. Field cannot be empty.", "InformationOutline", MessageBoxButton.OK);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}