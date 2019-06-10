using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okurleiga_hf.Models;

namespace Okurleiga_hf.Models
{
    class ApartmentOwner : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
                
        public int Id { get; set; }
        public Apartment Apartment { get; set; }
        public string CompanyName { get; set; }
        

        private string _contactFirstName;
        public string ContactFirstName
        {
            get
            {
                return _contactFirstName;
            }
            set
            {
                _contactFirstName = value;
                INotifyPropertyChanged("ContactFullName");
                INotifyPropertyChanged("ContactFirstName");
            }
        }

        private string _contactLastName;
        public string ContactLastName
        {
            get
            {
                return _contactLastName;
            }
            set
            {
                _contactLastName = value;
                INotifyPropertyChanged("ContactFullName");
                INotifyPropertyChanged("ContactLastName");

            }
        }
        public string ContactFullName
        {
            get
            {
                return ContactFirstName + " " + ContactLastName;
            }
        }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        public ObservableCollection<Apartment> Apartments { get; set; }

        public ApartmentOwner()
        {
            this.Apartments = new ObservableCollection<Apartment>();
        }
        public string Email { get; set; }





        private void INotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
