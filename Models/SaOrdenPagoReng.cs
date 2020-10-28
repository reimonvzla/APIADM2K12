using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaOrdenPagoReng
    {
        public int RengNum { get; set; }
        public string OrdNum { get; set; }
        public string CoCtaIngrEgr { get; set; }
        public string CoIslr { get; set; }
        public decimal MontoD { get; set; }
        public decimal MontoH { get; set; }
        public decimal MontoIva { get; set; }
        public decimal PorcRetn { get; set; }
        public decimal? MontoObj { get; set; }
        public decimal Sustraendo { get; set; }
        public decimal MontoReten { get; set; }
        public string TipoImp { get; set; }
        public string Descrip { get; set; }
        public string DisCen { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaCuentaIngEgr CoCtaIngrEgrNavigation { get; set; }
        public virtual SaConIslr CoIslrNavigation { get; set; }
        public virtual SaOrdenPago OrdNumNavigation { get; set; }
    }
}
