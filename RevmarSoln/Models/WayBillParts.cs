//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SahinRektefiyeSoln.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WayBillParts
    {
        public int WayBillPartId { get; set; }
        public int WayBillId { get; set; }
        public int PartId { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual Parts Parts { get; set; }
        public virtual WayBills WayBills { get; set; }
    }
}
