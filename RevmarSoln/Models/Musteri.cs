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
    
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            this.Irsaliyeler = new HashSet<Irsaliyeler>();
            this.IsEmirleri = new HashSet<IsEmirleri>();
            this.IsEmirleri1 = new HashSet<IsEmirleri>();
            this.IsEmirleri2 = new HashSet<IsEmirleri>();
            this.IsEmirleri3 = new HashSet<IsEmirleri>();
            this.KvkMusteriLogs = new HashSet<KvkMusteriLogs>();
            this.MusteriAraclari = new HashSet<MusteriAraclari>();
            this.MusteriMail = new HashSet<MusteriMail>();
            this.MusteriTelefon = new HashSet<MusteriTelefon>();
            this.Teklifler = new HashSet<Teklifler>();
            this.Talepler = new HashSet<Talepler>();
        }
    
        public int MusteriId { get; set; }
        public string MusteriTipi { get; set; }
        public string CariKod { get; set; }
        public bool SWEFaturaMukellefi { get; set; }
        public bool SWEArsivMukellefi { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string Cinsiyet { get; set; }
        public string TCKN { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<int> IlId { get; set; }
        public Nullable<int> IlceId { get; set; }
        public Nullable<int> MeslekId { get; set; }
        public string KontakAdi { get; set; }
        public string KontakSoyadi { get; set; }
        public Nullable<int> KurumTipId { get; set; }
        public string VergiNo { get; set; }
        public Nullable<int> KontakKategoriId { get; set; }
        public Nullable<int> VergiDairesiIlId { get; set; }
        public Nullable<int> VergiDairesiIlceId { get; set; }
        public string Adres { get; set; }
        public Nullable<int> Vade { get; set; }
        public string Note { get; set; }
        public string MuhasebeKodu { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Modifier { get; set; }
        public Nullable<System.DateTime> DtModified { get; set; }
        public Nullable<int> ParcaIskonto { get; set; }
        public Nullable<int> IscilikIskonto { get; set; }
        public string KurumAdi { get; set; }
        public Nullable<int> MusteriLogoId { get; set; }
        public string VergiDairesi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Irsaliyeler> Irsaliyeler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsEmirleri> IsEmirleri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsEmirleri> IsEmirleri1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsEmirleri> IsEmirleri2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IsEmirleri> IsEmirleri3 { get; set; }
        public virtual ilceler ilceler { get; set; }
        public virtual ilceler ilceler1 { get; set; }
        public virtual iller iller { get; set; }
        public virtual iller iller1 { get; set; }
        public virtual KontakKategorileri KontakKategorileri { get; set; }
        public virtual KurumTipleri KurumTipleri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KvkMusteriLogs> KvkMusteriLogs { get; set; }
        public virtual Meslekler Meslekler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriAraclari> MusteriAraclari { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriMail> MusteriMail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriTelefon> MusteriTelefon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teklifler> Teklifler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Talepler> Talepler { get; set; }
    }
}
