//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblFaturaBilgi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblFaturaBilgi()
        {
            this.TblFaturaDetay = new HashSet<TblFaturaDetay>();
        }
    
        public int ID { get; set; }
        public string Seri { get; set; }
        public string SiraNo { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Saat { get; set; }
        public string VergiDairesi { get; set; }
        public Nullable<int> Cari { get; set; }
        public Nullable<short> Personel { get; set; }
    
        public virtual TblCari TblCari { get; set; }
        public virtual TblPersonel TblPersonel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFaturaDetay> TblFaturaDetay { get; set; }
    }
}
