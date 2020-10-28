using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaChequeDevueltoCompra
    {
        public string CoCheqDev { get; set; }
        public string DesCheqDev { get; set; }
        public string CoProv { get; set; }
        public DateTime Fecha { get; set; }
        public string NumDoc { get; set; }
        public bool IncluyeImp { get; set; }
        public string CodCta { get; set; }
        public string CoTipoDoc { get; set; }
        public string NroDoc { get; set; }
        public decimal MontDoc { get; set; }
        public DateTime FecCheq { get; set; }
        public string CoBan { get; set; }
        public string TipImp { get; set; }
        public bool Procesado { get; set; }
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

        public virtual SaProveedor CoProvNavigation { get; set; }
        public virtual SaDocumentoCompra SaDocumentoCompra { get; set; }
    }
}
