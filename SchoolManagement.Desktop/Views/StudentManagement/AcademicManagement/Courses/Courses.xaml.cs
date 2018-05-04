using StudentManagement.Desktop.ViewModels;
using Hammer.MDIContainer.Control;
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

namespace SchoolManagement.Desktop.Views.StudentManagement.AcademicManagement.Courses
{
    /// <summary>
    /// Interaction logic for Courses.xaml
    /// </summary>
    public partial class Courses : UserControl
    {
        private CoursesViewModel coursesViewModel;

        public Courses()
        {
            InitializeComponent();
            DataContext = coursesViewModel = new CoursesViewModel();
        }

        public override string ToString() => "courses";

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Helpers.WindowHelper.CloseWindow(this.Parent);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditSelectedItem();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string windowTitle = "Add Course";
            MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
            MdiWindow item = new MdiWindow
            {
                Title = windowTitle,
                CanClose = true,
                IsModal = false,
                Content = new _Course(windowTitle, null),
                WindowID = "AddCourse",
                ParentTitle = ((MdiWindow)this.Parent).Title,
                ParentSelectedIndex = ((MdiWindow)this.Parent).ParentSelectedIndex
            };
            item.Closing += (s, f) => container.Items.Remove(item);
            container.Items.Add(item);
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            EditSelectedItem();
        }

        private void EditSelectedItem()
        {
            try
            {
                string windowTitle = "Edit Course";
                MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
                MdiWindow item = new MdiWindow
                {
                    Title = windowTitle,
                    CanClose = true,
                    IsModal = false,
                    Content = new _Course(windowTitle, (Course)dataGrid.SelectedItem),
                    WindowID = "EditCourse",
                    ParentTitle = ((MdiWindow)this.Parent).Title,
                    ParentSelectedIndex = ((MdiWindow)this.Parent).ParentSelectedIndex,
                };
                item.Closing += (s, f) => container.Items.Remove(item);
                container.Items.Add(item);
            }
            catch (Exception)
            {
            }
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadItems();
        }

        public async Task LoadItems()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                try
                {
                    coursesViewModel.Courses = new ObservableCollection<Course>(await db.Courses.ToListAsync());
                }
                catch (Exception ex)
                {
                    Helpers.WindowHelper.CatchException(ex);
                }
            }
        }
    }
}