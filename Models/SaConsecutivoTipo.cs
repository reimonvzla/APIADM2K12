using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaConsecutivoTipo
    {
        public SaConsecutivoTipo()
        {
            SaConsecutivo = new HashSet<SaConsecutivo>();
        }

        public string CoConsecutivo { get; set; }
        public string DesConsecutivo { get; set; }
        public bool? UsoEmpresa { get; set; }
        public bool UsoSucursal { get; set; }
        public string Modulo { get; set; }
        public string Tabla { get; set; }
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

        public virtual ICollection<SaConsecutivo> SaConsecutivo { get; set; }
    }
}
