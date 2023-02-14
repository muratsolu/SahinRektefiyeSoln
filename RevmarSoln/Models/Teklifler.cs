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
    
    public partial class Teklifler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teklifler()
        {
            this.TeklifKalemleri = new HashSet<TeklifKalemleri>();
        }
    
        public System.Guid TeklifId { get; set; }
        public int TeklifNo { get; set; }
        public int MusteriId { get; set; }
        public int AracId { get; set; }
        public int IsEmriTipId { get; set; }
        public System.DateTime TeklifTarihi { get; set; }
        public int TeklifStatuId { get; set; }
        public Nullable<int> IsEmriId { get; set; }
        public Nullable<System.DateTime> IsEmriTarihi { get; set; }
        public string TeklifNot { get; set; }
        public Nullable<decimal> KdvsizTutar { get; set; }
        public Nullable<decimal> ToplamKdv { get; set; }
        public Nullable<decimal> ToplamIskonto { get; set; }
        public Nullable<decimal> KdvliTutar { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> DtCreated { get; set; }
        public string Modifier { get; set; }
        public Nullable<System.DateTime> DtModified { get; set; }
        public string IptalNedeni { get; set; }
        public string IptalEdenKisi { get; set; }
        public Nullable<System.DateTime> IptalTarihi { get; set; }
    
        public virtual Arac Arac { get; set; }
        public virtual IsEmirleri IsEmirleri { get; set; }
        public virtual IsEmriTipleri IsEmriTipleri { get; set; }
        public virtual Musteri Musteri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeklifKalemleri> TeklifKalemleri { get; set; }
        public virtual TeklifStatu TeklifStatu { get; set; }
    }
}
