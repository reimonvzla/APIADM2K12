using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaConfigFacturaVenta
    {
        public string CoConfig { get; set; }
        public string DesConfig { get; set; }
        public string CoUsuario { get; set; }
        public string CoMapa { get; set; }
        public string XmlSquema { get; set; }
        public string XmlData { get; set; }
        public string XmlReglas { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public byte[] Validador { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
    }
}
