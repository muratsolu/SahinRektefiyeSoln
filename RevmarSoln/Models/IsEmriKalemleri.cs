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
    
    public partial class IsEmriKalemleri
    {
        public int IsEmriKalemId { get; set; }
        public string KalepTipi { get; set; }
        public Nullable<int> IscilikId { get; set; }
        public Nullable<int> StokKartId { get; set; }
        public Nullable<decimal> BirimSaatAdet { get; set; }
        public int IsEmriId { get; set; }
        public Nullable<decimal> IskontoOrani { get; set; }
        public Nullable<decimal> BirimIndirimFiyat { get; set; }
        public Nullable<decimal> KalemTutar { get; set; }
        public Nullable<decimal> KdvliKalemTutar { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool SwAtolyeTeslim { get; set; }
        public decimal TeslimEdilenMiktar { get; set; }
        public Nullable<decimal> MaliyetDyi { get; set; }
        public Nullable<decimal> DyiIlkSatisFiyati { get; set; }
        public string ParcaEklemeTipi { get; set; }
        public Nullable<decimal> ManuelSatisFiyat { get; set; }
        public string ManuelIscilikKodu { get; set; }
        public string IscilikAciklama { get; set; }
        public Nullable<int> IsEmriTipId { get; set; }
        public string IsEmriTipAciklamasi { get; set; }
        public bool IsKonsinye { get; set; }
        public bool KonsinyeIcinParcaGeldiMi { get; set; }
        public string KonsinyeIcinGelenParcaKodu { get; set; }
        public Nullable<int> KonsinyeIcinGelenStokKartId { get; set; }
    
        public virtual Iscilikler Iscilikler { get; set; }
        public virtual IsEmirleri IsEmirleri { get; set; }
        public virtual IsEmriTipleri IsEmriTipleri { get; set; }
        public virtual StokKarti StokKarti { get; set; }
        public virtual StokKarti StokKarti1 { get; set; }
    }
}
