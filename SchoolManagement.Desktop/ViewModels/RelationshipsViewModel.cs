using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class RelationshipsViewModel : ViewModelBase
    {
        private ObservableCollection<HRRelationship> relationships;

        public ObservableCollection<HRRelationship> Relationships
        {
            get { return relationships; }
            set
            {
                if (relationships != value)
                {
                    relationships = value;
                    NotifyPropertyChanged("Relationships");
                }
            }
        }
    }
}
