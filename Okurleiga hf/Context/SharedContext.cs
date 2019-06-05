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

        public static ObservableCollection<Apartment> apartments = new ObservableCollection<Apartment>();        
        public static ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
        public static ObservableCollection<ApartmentIncident> apartmentIncidents = new ObservableCollection<ApartmentIncident>();        
        public static ObservableCollection<Employee> employees = new ObservableCollection<Employee>();        
        public static ObservableCollection<ApartmentOwner> apartmentOwners = new ObservableCollection<ApartmentOwner>();        
        public static ObservableCollection<Rent> rents = new ObservableCollection<Rent>();
    }
}
