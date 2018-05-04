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
using SchoolManagement.Desktop.ViewModels;

namespace SchoolManagement.Desktop.Views.StudentManagement.AcademicManagement.Modules
{
    /// <summary>
    /// Interaction logic for Modules.xaml
    /// </summary>
    public partial class Modules : UserControl
    {
        private ModulesViewModel modulesViewModel;

        public Modules()
        {
            InitializeComponent();
            DataContext = modulesViewModel = new ModulesViewModel();
        }

        public override string ToString() => "modules";

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
            string windowTitle = "Add Module";
            MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
            MdiWindow item = new MdiWindow
            {
                Title = windowTitle,
                CanClose = true,
                IsModal = false,
                Content = new _Module(windowTitle, null),
                WindowID = "AddModule",
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
                string windowTitle = "Edit Module";
                MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
                MdiWindow item = new MdiWindow
                {
                    Title = windowTitle,
                    CanClose = true,
                    IsModal = false,
                    Content = new _Module(windowTitle, (Module)dataGrid.SelectedItem),
                    WindowID = "EditModule",
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
                    modulesViewModel.Modules = new ObservableCollection<Module>(await db.Modules.Include(r => r.Course).ToListAsync());
                }
                catch (Exception ex)
                {
                    Helpers.WindowHelper.CatchException(ex);
                }
            }
        }
    }
}