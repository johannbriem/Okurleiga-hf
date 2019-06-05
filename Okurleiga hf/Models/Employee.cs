using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleiga_hf.Models
{
    class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int EmployeeID { get; set; }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                INotifyPropertyChanged("FullName");
                INotifyPropertyChanged("FirstName");
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                INotifyPropertyChanged("FullName");
                INotifyPropertyChanged("LastName");

            }
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public uint SocialNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        public DateTime DateStart { get; set; }
        public ObservableCollection<Rent> Rents { get; set; }

        public Employee()
        {
            this.Rents = new ObservableCollection<Rent>();
        }


        private void INotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

    }
}
