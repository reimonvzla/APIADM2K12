using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaCotizacionCliente
    {
        public string DocNum { get; set; }
        public string CoCli { get; set; }
        public DateTime FecEmis { get; set; }
        public string Status { get; set; }
        public decimal TotalNeto { get; set; }
        public string CliDes { get; set; }
        public string Descrip { get; set; }
        public string CoTran { get; set; }
        public string CoMone { get; set; }
        public string CoVen { get; set; }
        public string CoCond { get; set; }
        public string NControl { get; set; }
        public decimal Saldo { get; set; }
        public string Impfis { get; set; }
        public string Impfisfac { get; set; }
    }
}
