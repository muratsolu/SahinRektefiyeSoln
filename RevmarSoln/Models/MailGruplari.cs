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
    
    public partial class MailGruplari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MailGruplari()
        {
            this.MailAdresleri = new HashSet<MailAdresleri>();
        }
    
        public int MailGrupId { get; set; }
        public string MailGrupAdi { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ExcelPath { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MailAdresleri> MailAdresleri { get; set; }
    }
}
