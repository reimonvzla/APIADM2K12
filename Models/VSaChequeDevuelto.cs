using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaChequeDevuelto
    {
        public string CobNum { get; set; }
        public string FormaPag { get; set; }
        public string CodCta { get; set; }
        public decimal MontDoc { get; set; }
        public DateTime FechaChe { get; set; }
        public string MovNumB { get; set; }
        public string NumDoc { get; set; }
        public string CoProv { get; set; }
        public string ProvDes { get; set; }
        public string CoTipoDoc { get; set; }
        public string CoCtaIngrEgr { get; set; }
        public decimal Tasa { get; set; }
        public string DocNum { get; set; }
        public string TipoImp { get; set; }
        public string DesBan { get; set; }
        public string CoBan { get; set; }
        public string NumCta { get; set; }
        public string CoMone { get; set; }
        public bool Devuelto { get; set; }
        public bool Inactivo { get; set; }
        public bool Anulado { get; set; }
    }
}
