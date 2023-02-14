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
    
    public partial class Danismanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Danismanlar()
        {
            this.IsEmirleri = new HashSet<IsEmirleri>();
        }
    
        public int DanismanId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool SwAktif { get; set; }
        public System.DateTime IseGirisTarihi { get; set; }
        public Nullable<System.DateTime> IstenCikisTarihi { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Modifier { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool SwTeknisyen { get; set; }
        public bool SwSofor { get; set; }
        public string UserName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsEmirleri> IsEmirleri { get; set; }
    }
}
