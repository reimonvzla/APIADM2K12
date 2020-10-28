using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaDepositoBanco
    {
        public SaDepositoBanco()
        {
            SaDepositoBancoReng = new HashSet<SaDepositoBancoReng>();
        }

        public string DepNum { get; set; }
        public string Deposito { get; set; }
        public DateTime Fecha { get; set; }
        public string CodCta { get; set; }
        public string CodCaja { get; set; }
        public string MovNumB { get; set; }
        public string MovNumC { get; set; }
        public decimal TotalEfec { get; set; }
        public int CheDev { get; set; }
        public string CoCtaIngrEgr { get; set; }
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }
        public string DisCen { get; set; }
        public decimal Tasa { get; set; }
        public decimal? Aux01 { get; set; }
        public string Aux02 { get; set; }
        public bool Activado { get; set; }
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

        public virtual SaCuentaIngEgr CoCtaIngrEgrNavigation { get; set; }
        public virtual SaCaja CodCajaNavigation { get; set; }
        public virtual SaCuentaBancaria CodCtaNavigation { get; set; }
        public virtual ICollection<SaDepositoBancoReng> SaDepositoBancoReng { get; set; }
    }
}
