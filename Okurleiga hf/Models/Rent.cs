using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleiga_hf.Models
{
    class Rent
    {
        public int RentID { get; set; }
        public int ApartmentID { get; set; }
        public DateTime RentDate { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public ObservableCollection<Apartment> Apartments { get; set; }
        public ObservableCollection<Employee> Employees { get; set; }
        public ObservableCollection<Customer> Customers { get; set; }

        public Rent()
        {
            this.Apartments = new ObservableCollection<Apartment>();
            this.Employees = new ObservableCollection<Employee>();
            this.Customers = new ObservableCollection<Customer>();
        }

        //public virtual Apartment Apartment { get; set; }
    }
}
