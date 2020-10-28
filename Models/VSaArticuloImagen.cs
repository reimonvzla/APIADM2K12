using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaArticuloImagen
    {
        public string CoTipoDoc { get; set; }
        public Guid Rowguid { get; set; }
        public string CoImag { get; set; }
        public string DesImag { get; set; }
        public byte[] Picture { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public string CoArt { get; set; }
    }
}
