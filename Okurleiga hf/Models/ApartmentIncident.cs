using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okurleiga_hf.Models;

namespace Okurleiga_hf.Models
{
    class ApartmentIncident
    {        
        public int Id { get; set; }
        public Apartment Apartment { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterName { get; set; }
        public string IncidentInfo { get; set; }
        

        //public ApartmentIncident()
        //{
        //    this.Apartments = new ObservableCollection<Apartment>();
        //}
    }
}
