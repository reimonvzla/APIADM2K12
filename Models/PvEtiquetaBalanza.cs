using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class PvEtiquetaBalanza
    {
        public string CoEtiqueta { get; set; }
        public string DesEtiqueta { get; set; }
        public int Pre { get; set; }
        public int Cod { get; set; }
        public int Suf { get; set; }
        public int Ent { get; set; }
        public int Dec { get; set; }
        public int Adic { get; set; }
        public bool? Activo { get; set; }
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
    }
}
