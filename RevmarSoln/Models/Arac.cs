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
    
    public partial class Arac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arac()
        {
            this.IsEmirleri = new HashSet<IsEmirleri>();
            this.MusteriAraclari = new HashSet<MusteriAraclari>();
            this.Teklifler = new HashSet<Teklifler>();
        }
    
        public int AracId { get; set; }
        public string SaseNo { get; set; }
        public string MotorNo { get; set; }
        public int CompanyId { get; set; }
        public int VehicleId { get; set; }
        public string AracModelAdi { get; set; }
        public Nullable<int> AracTipId { get; set; }
        public int ModelYili { get; set; }
        public string Plaka { get; set; }
        public Nullable<int> CariId { get; set; }
        public Nullable<int> RenkId { get; set; }
        public string IcRenk { get; set; }
        public Nullable<int> AracGrupId { get; set; }
        public Nullable<int> VitesTipId { get; set; }
        public Nullable<int> YakitTipId { get; set; }
        public Nullable<int> Km { get; set; }
        public Nullable<int> AktarmaTipId { get; set; }
        public string Notes { get; set; }
        public Nullable<int> AracDetayId { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Modifier { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool SwGunlukArac { get; set; }
    
        public virtual AktarmaTipi AktarmaTipi { get; set; }
        public virtual AracDetay AracDetay { get; set; }
        public virtual AracGrubu AracGrubu { get; set; }
        public virtual AracTipi AracTipi { get; set; }
        public virtual Companies Companies { get; set; }
        public virtual Renkler Renkler { get; set; }
        public virtual Vehicles Vehicles { get; set; }
        public virtual VitesTipi VitesTipi { get; set; }
        public virtual YakitTipi YakitTipi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsEmirleri> IsEmirleri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriAraclari> MusteriAraclari { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teklifler> Teklifler { get; set; }
    }
}
