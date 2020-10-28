using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaSerieTipo
    {
        public SaSerieTipo()
        {
            SaSerie = new HashSet<SaSerie>();
        }

        public string CoTipoSerie { get; set; }
        public string DesTipoSerie { get; set; }
        public string Prefijo { get; set; }
        public string Sufijo { get; set; }
        public int Longitud { get; set; }
        public string DesdeA { get; set; }
        public long? DesdeN { get; set; }
        public string HastaA { get; set; }
        public long? HastaN { get; set; }
        public int Tipo { get; set; }
        public bool Reiniciar { get; set; }
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
        public bool AplicaNcf { get; set; }

        public virtual SaSerieTipoExt SaSerieTipoExt { get; set; }
        public virtual ICollection<SaSerie> SaSerie { get; set; }
    }
}
