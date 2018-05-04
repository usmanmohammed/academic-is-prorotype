using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.ViewModels
{
    public class IPermissionViewModel : ViewModelBase
    {
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }

        private bool isChecked;

        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    NotifyPropertyChanged("IsChecked");
                }
            }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }

        private IPermissionViewModel parent;

        public IPermissionViewModel Parent
        {
            get { return parent; }
            set
            {
                if (parent != value)
                {
                    parent = value;
                    NotifyPropertyChanged("Parent");
                }
            }
        }
        private ObservableCollection<IPermissionViewModel> children;

        public ObservableCollection<IPermissionViewModel> Children
        {
            get { return children; }
            set
            {
                if (children != value)
                {
                    children = value;
                    NotifyPropertyChanged("Children");
                }
            }
        }
    }
}
