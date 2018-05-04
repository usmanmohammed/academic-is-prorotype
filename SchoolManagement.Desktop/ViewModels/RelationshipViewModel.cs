using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class RelationshipViewModel : ViewModelBase
    {
        private HRRelationship relationship;

        public HRRelationship Relationship
        {
            get { return relationship; }
            set
            {
                if (relationship != value)
                {
                    relationship = value;
                    NotifyPropertyChanged("Relationship");
                }
            }
        }
    }
}
