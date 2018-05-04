using SchoolManagement.Data.Models;
using SchoolManagement.Desktop.ViewModels;
using Hammer.MDIContainer.Control;
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
using SchoolManagement.Desktop.Views.StudentManagement.AcademicManagement.Modules;

namespace SchoolManagement.Desktop.Views.StudentsManagement.Courses
{
    /// <summary>
    /// Interaction logic for SearchCourse.xaml
    /// </summary>
    public partial class SearchCourse : UserControl
    {
        private string returnUrl;
        private SearchCourseViewModel searchCourseViewModel;
        private List<Course> courses;
        public override string ToString()
        {
            return "searchCourses";
        }
        public SearchCourse(string returnUrl)
        {
            InitializeComponent();
            this.returnUrl = returnUrl;
            searchCourseViewModel = new SearchCourseViewModel() { Courses = new ObservableCollection<Course>() };
            DataContext = searchCourseViewModel;
        }

        private void btnSearchAccount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception)
            {
            }
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadProgressBar();
            using (DatabaseContext db = new DatabaseContext())
            {
                try
                {
                    courses = await db.Courses.ToListAsync();
                    searchCourseViewModel.Courses = new ObservableCollection<Course>(courses);
                }
                catch (Exception ex)
                {
                    Helpers.WindowHelper.CatchException(ex);
                }
            }
            UnloadProgressBar();
            searchBox.Focus();
        }

        #region Helpers
        private void LoadProgressBar()
        {
            if (loadingBar.Visibility == Visibility.Collapsed)
            {
                loadingBar.Visibility = Visibility.Visible;
            }
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
                if (!string.IsNullOrEmpty(searchBox.Text))
                {
                    string query = searchBox.Text.ToLower();
                    var results = courses.Where(d => d.CourseCode.ToLower().Contains(query) ||
                    d.CourseDescription.ToLower().Contains(query)).ToList();

                    searchCourseViewModel.Courses = new ObservableCollection<Course>(results);
                }
            }
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                SetSelectedDataGridItem();
            }
            catch (Exception)
            {

            }
        }

        private void SetSelectedDataGridItem()
        {
            MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
            container.Items.Remove((MdiWindow)this.Parent);

            var selectedCourse = (Course)dataGrid.SelectedItem;
            App.Current.Properties["SelectedCourse"] = selectedCourse;

            if (returnUrl == "module")
            {
                var moduleWindow = (container.Items.OfType<MdiWindow>()).Where(r => r.Content.ToString() == returnUrl).First();
                ((_Module)moduleWindow.Content).Refresh();
                moduleWindow.IsSelected = true;
                moduleWindow.Focus();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Helpers.WindowHelper.CloseWindow(this.Parent);
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SetSelectedDataGridItem();
            }
            catch (Exception)
            {

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

        private void btnFindCourse_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
