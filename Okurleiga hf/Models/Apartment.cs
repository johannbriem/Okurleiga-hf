using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okurleiga_hf.Models;

namespace Okurleiga_hf.Models
{
    class Apartment
    {

        public int Id { get; set; }
        public ApartmentOwner ApartmentOwner { get; set; }
        public DateTime RegisteredAt { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public int Bedroom { get; set; }
        public int Bathroom { get; set; }
        public int Size { get; set; }
        public int RentPrize { get; set; }
        public bool Available { get; set; }
        public string RentType { get; set; }
        public bool Garage { get; set; }
        public bool Smoking { get; set; }
        public bool Pet { get; set; }
        public string Type { get; set; }
        //public ObservableCollection<Rent> Rents { get; set; }

        //public Apartment()
        //{
        //    this.Rents = new ObservableCollection<Rent>();
        //}



    }
}
