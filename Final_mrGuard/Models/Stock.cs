//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_mrGuard.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int Category_ID { get; set; }
        public int Product_ID { get; set; }
        public int Stock_Quantity { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
