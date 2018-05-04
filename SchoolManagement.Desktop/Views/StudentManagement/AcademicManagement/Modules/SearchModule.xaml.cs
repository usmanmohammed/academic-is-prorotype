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

namespace SchoolManagement.Desktop.Views.StudentsManagement.Modules
{
    /// <summary>
    /// Interaction logic for SearchModule.xaml
    /// </summary>
    public partial class SearchModule : UserControl
    {
        private string returnUrl;
        private SearchModuleViewModel searchModuleViewModel;
        private List<Module> modules;
        public override string ToString()
        {
            return "searchModules";
        }
        public SearchModule(string returnUrl)
        {
            InitializeComponent();
            this.returnUrl = returnUrl;
            searchModuleViewModel = new SearchModuleViewModel() { Modules = new ObservableCollection<Module>() };
            DataContext = searchModuleViewModel;
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
                    modules = await db.Modules.ToListAsync();
                    searchModuleViewModel.Modules = new ObservableCollection<Module>(modules);
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

                    var results = modules.Where(d => d.ModuleCode.ToLower().Contains(query) ||
                    d.ModuleDescription.ToLower().Contains(query)).ToList();

                    searchModuleViewModel.Modules = new ObservableCollection<Module>(results);
                }
            }
        }

        private async void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                await SetSelectedDataGridItem();
            }
            catch (Exception)
            {

            }
        }

        private async Task SetSelectedDataGridItem()
        {
            MdiContainer container = ((MdiWindow)this.Parent).Parent as MdiContainer;
            container.Items.Remove((MdiWindow)this.Parent);

            var selectedModule = (Module)dataGrid.SelectedItem;
            App.Current.Properties["SelectedModule"] = selectedModule;

            if (returnUrl == "postStudentsResults")
            {
                //var postStudentsResultWindow = (container.Items.OfType<MdiWindow>()).Where(r => r.Content.ToString() == "postStudentsResults").First();
                //await ((PostStudentsResults)postStudentsResultWindow.Content).Refresh();
                //postStudentsResultWindow.IsSelected = true;
                //postStudentsResultWindow.Focus();
            }      
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Helpers.WindowHelper.CloseWindow(this.Parent);
        }

        private async void btnView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await SetSelectedDataGridItem();
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

        private void btnFindModule_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
