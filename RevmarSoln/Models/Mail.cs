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
    
    public partial class Mail
    {
        public int MailId { get; set; }
        public string Kime { get; set; }
        public string Konu { get; set; }
        public string Icerik { get; set; }
        public string Ek { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Creator { get; set; }
    }
}
