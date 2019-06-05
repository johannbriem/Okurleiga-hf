using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleiga_hf.Models
{
    class ApartmentIncident
    {
        [Key]
        public int IncidentID { get; set; }
        public int ApartmentID { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterName { get; set; }
        public string IncidentInfo { get; set; }
        public ObservableCollection<Apartment> Apartments { get; set; }

        public ApartmentIncident()
        {
            this.Apartments = new ObservableCollection<Apartment>();
        }
    }
}
