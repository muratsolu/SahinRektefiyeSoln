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
    
    public partial class TurboSarjFixing
    {
        public int TurbosarjFixId { get; set; }
        public Nullable<int> WorkOrderId { get; set; }
        public bool SwTamirTakimindaAsinma { get; set; }
        public bool SwYahKapagindaAsinma { get; set; }
        public bool SwKomprosorPervanesindeHasar { get; set; }
        public bool SwTurbinMilindeHasar { get; set; }
        public bool SwVNTMekanizmasindaHasar { get; set; }
        public bool SwMerkezGovdeHasar { get; set; }
        public bool SwCartridgeKompleHasar { get; set; }
        public bool SwWastegateHasar { get; set; }
        public bool SwEgzosSalyangozundaHasar { get; set; }
        public bool SwKomprasorSalyangozundaHasar { get; set; }
        public bool SwKompleTurboHasar { get; set; }
        public bool SwVNTMekanizmasindaAsiriKurum { get; set; }
        public string TespitAciklama { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> IsEmriId { get; set; }
    
        public virtual IsEmirleri IsEmirleri { get; set; }
        public virtual WorkOrders WorkOrders { get; set; }
    }
}
