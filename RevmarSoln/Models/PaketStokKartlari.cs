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
    
    public partial class PaketStokKartlari
    {
        public int PaketStokKartId { get; set; }
        public int PaketId { get; set; }
        public int StokKartId { get; set; }
        public decimal Adet { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Paketler Paketler { get; set; }
        public virtual StokKarti StokKarti { get; set; }
    }
}
