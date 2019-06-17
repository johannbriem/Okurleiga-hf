using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okurleiga_hf.Context;
using Okurleiga_hf.Models;

namespace Okurleiga_hf.Models
{
    class Rent
    {
        public int Id { get; set; }
        public Apartment Apartment { get; set; }
        public DateTime RentDate { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }       

    }
}
