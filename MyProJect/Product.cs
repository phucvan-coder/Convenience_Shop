//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProJect
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public int TypeID { get; set; }
        public string ProductName { get; set; }
        public int ProducerID { get; set; }
        public Nullable<double> Price { get; set; }
        public string Status { get; set; }
    
        public virtual Producer Producer { get; set; }
        public virtual TypeOfProduct TypeOfProduct { get; set; }
    }
}
