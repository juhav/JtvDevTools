using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient.Models
{
    public class ModelBase : INotifyPropertyChanged
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsNew { get; set; }
        public bool IsModified { get; set; }

        public ModelBase()
        {
            Id = Guid.NewGuid();
            IsNew = true;
            IsModified = false;
        }

        protected void SetPropertyValue(ref string property, ref string value, string propertyName, bool trim = false)
        {
            if (value != property)
            {
                property = trim ? (value ?? "").Trim() : value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                IsModified = true;
            }
        }

        protected void SetPropertyValue(ref bool property, ref bool value, string propertyName)
        {
            if (value != property)
            {
                property = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                IsModified = true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
