using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaSerie
    {
        public SaSerie()
        {
            SaConsecutivo = new HashSet<SaConsecutivo>();
            SaNcfinfoDocCompra = new HashSet<SaNcfinfoDocCompra>();
            SaNcfinfoDocVenta = new HashSet<SaNcfinfoDocVenta>();
            StgFactLoteGenCoSerieFactNavigation = new HashSet<StgFactLoteGen>();
            StgFactLoteGenCoSerieNctrlNavigation = new HashSet<StgFactLoteGen>();
        }

        public int RengNum { get; set; }
        public string CoTipoSerie { get; set; }
        public string CoSerie { get; set; }
        public string DesdeA { get; set; }
        public long? DesdeN { get; set; }
        public string HastaA { get; set; }
        public long? HastaN { get; set; }
        public string ProxA { get; set; }
        public long? ProxN { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaSerieTipo CoTipoSerieNavigation { get; set; }
        public virtual ICollection<SaConsecutivo> SaConsecutivo { get; set; }
        public virtual ICollection<SaNcfinfoDocCompra> SaNcfinfoDocCompra { get; set; }
        public virtual ICollection<SaNcfinfoDocVenta> SaNcfinfoDocVenta { get; set; }
        public virtual ICollection<StgFactLoteGen> StgFactLoteGenCoSerieFactNavigation { get; set; }
        public virtual ICollection<StgFactLoteGen> StgFactLoteGenCoSerieNctrlNavigation { get; set; }
    }
}
