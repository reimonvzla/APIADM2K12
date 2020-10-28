using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaAjPrecioCostoM
    {
        public SaAjPrecioCostoM()
        {
            SaAjPrecioCostoReng = new HashSet<SaAjPrecioCostoReng>();
        }

        public string CodAjuste { get; set; }
        public string DesAjuste { get; set; }
        public string CoAlma { get; set; }
        public int TipoAjuste { get; set; }
        public string TipoAjustePrecio { get; set; }
        public string TipoAjusteCosto { get; set; }
        public string MargenSuperior { get; set; }
        public string MargenInferior { get; set; }
        public string CoArtDesde { get; set; }
        public string CoArtHasta { get; set; }
        public string CoLin { get; set; }
        public string CoSubl { get; set; }
        public string CoCat { get; set; }
        public string CoProv { get; set; }
        public string Item { get; set; }
        public bool Procesado { get; set; }
        public DateTime? Fecha { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<SaAjPrecioCostoReng> SaAjPrecioCostoReng { get; set; }
    }
}
