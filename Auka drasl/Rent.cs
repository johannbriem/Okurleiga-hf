//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Okurleiga_hf
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rent
    {
        public int Id { get; set; }
        public System.DateTime RentDate { get; set; }
        public Nullable<int> Apartment_Id { get; set; }
        public Nullable<int> Customer_CustomerID { get; set; }
        public Nullable<int> Employee_EmployeeID { get; set; }
    
        public virtual Apartment Apartment { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
