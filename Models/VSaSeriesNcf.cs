using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaSeriesNcf
    {
        public string Serie { get; set; }
        public string Consecutivo { get; set; }
        public string CoConsecutivo { get; set; }
        public bool Usoempresa { get; set; }
        public bool UsoSucursal { get; set; }
        public string CoEmp { get; set; }
        public string CoSucur { get; set; }
    }
}
