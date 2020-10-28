using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaConsecutivo
    {
        public string CoEmp { get; set; }
        public string CoSucur { get; set; }
        public string Codigo { get; set; }
        public string CoConsecutivo { get; set; }
        public string CoSerie { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public byte[] Validador { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
        public string CoSucuIn { get; set; }
        public string CoSucuMo { get; set; }

        public virtual SaConsecutivoTipo CoConsecutivoNavigation { get; set; }
        public virtual ParEmp CoEmpNavigation { get; set; }
        public virtual SaSerie CoSerieNavigation { get; set; }
        public virtual SaSucursal CoSucurNavigation { get; set; }
    }
}
