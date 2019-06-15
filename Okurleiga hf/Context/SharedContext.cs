using Okurleiga_hf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleiga_hf.Context
{
    class SharedContext
    {
        public static ApartmentDBContext dBContext = new ApartmentDBContext();

        public static ObservableCollection<Apartment> Apartments = new ObservableCollection<Apartment>();
        public static ObservableCollection<Customer> Customers = new ObservableCollection<Customer>();
        public static ObservableCollection<ApartmentIncident> ApartmentIncidents = new ObservableCollection<ApartmentIncident>();
        public static ObservableCollection<ApartmentOwner> ApartmentOwners = new ObservableCollection<ApartmentOwner>();
        public static ObservableCollection<Rent> Rents = new ObservableCollection<Rent>();
        public static ObservableCollection<Employee> Employees = new ObservableCollection<Employee>();
    }
}
