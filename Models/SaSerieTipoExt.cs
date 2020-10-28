using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaSerieTipoExt
    {
        public Guid RowguidSerietipo { get; set; }
        public string CoSerie { get; set; }
        public string CoNegocio { get; set; }
        public string PuntoEmi { get; set; }
        public string AreaImp { get; set; }
        public string CoTipo { get; set; }
        public DateTime FeVenc { get; set; }
        public int Notidiavenc { get; set; }
        public int Notifinserie { get; set; }
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
        public string Transfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaAreaImpresion AreaImpNavigation { get; set; }
        public virtual SaPuntoEmision PuntoEmiNavigation { get; set; }
        public virtual SaSerieTipo RowguidSerietipoNavigation { get; set; }
    }
}
