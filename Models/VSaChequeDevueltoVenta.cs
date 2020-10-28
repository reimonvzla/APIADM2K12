using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaChequeDevueltoVenta
    {
        public string CobNum { get; set; }
        public string CoVen { get; set; }
        public string FormaPag { get; set; }
        public string CodCaja { get; set; }
        public decimal MontDoc { get; set; }
        public DateTime FechaChe { get; set; }
        public string NumDoc { get; set; }
        public bool Devuelto { get; set; }
        public string CoMone { get; set; }
        public string Descrip { get; set; }
        public string CoBan { get; set; }
        public string DesBan { get; set; }
        public string CoCli { get; set; }
        public string CliDes { get; set; }
        public string CoTipoDoc { get; set; }
        public string TipoImp { get; set; }
        public string CoCtaIngrEgr { get; set; }
        public decimal Tasa { get; set; }
        public string DocNum { get; set; }
        public string MovNumC { get; set; }
        public string CodCta { get; set; }
        public bool Inactivo { get; set; }
    }
}
