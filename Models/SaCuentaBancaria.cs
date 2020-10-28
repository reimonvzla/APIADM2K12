using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaCuentaBancaria
    {
        public SaCuentaBancaria()
        {
            SaChequera = new HashSet<SaChequera>();
            SaCobroTpreng = new HashSet<SaCobroTpreng>();
            SaConciliacionAutoReng = new HashSet<SaConciliacionAutoReng>();
            SaDepositoBanco = new HashSet<SaDepositoBanco>();
            SaMovimientoBanco = new HashSet<SaMovimientoBanco>();
            SaOrdenPago = new HashSet<SaOrdenPago>();
            SaPagoTpreng = new HashSet<SaPagoTpreng>();
            SaSaldoBanco = new HashSet<SaSaldoBanco>();
            SaTransferenciaEntreCuentasCtaComisionNavigation = new HashSet<SaTransferenciaEntreCuentas>();
            SaTransferenciaEntreCuentasCtaDestinoNavigation = new HashSet<SaTransferenciaEntreCuentas>();
            SaTransferenciaEntreCuentasCtaOrigenNavigation = new HashSet<SaTransferenciaEntreCuentas>();
        }

        public string CodCta { get; set; }
        public string CoBan { get; set; }
        public string CoMone { get; set; }
        public string NumCta { get; set; }
        public int? Numcom { get; set; }
        public DateTime? Feccom { get; set; }
        public string DisCen { get; set; }
        public string Telefonos { get; set; }
        public string Sucursal { get; set; }
        public DateTime MesIni { get; set; }
        public bool Inactivo { get; set; }
        public bool UsaChra { get; set; }
        public string EjecCu { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string TipoCu { get; set; }
        public DateTime Fecini { get; set; }
        public DateTime FecChra { get; set; }
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
        public decimal? AuxImp01 { get; set; }
        public decimal? AuxImp02 { get; set; }

        public virtual SaBanco CoBanNavigation { get; set; }
        public virtual SaMoneda CoMoneNavigation { get; set; }
        public virtual ICollection<SaChequera> SaChequera { get; set; }
        public virtual ICollection<SaCobroTpreng> SaCobroTpreng { get; set; }
        public virtual ICollection<SaConciliacionAutoReng> SaConciliacionAutoReng { get; set; }
        public virtual ICollection<SaDepositoBanco> SaDepositoBanco { get; set; }
        public virtual ICollection<SaMovimientoBanco> SaMovimientoBanco { get; set; }
        public virtual ICollection<SaOrdenPago> SaOrdenPago { get; set; }
        public virtual ICollection<SaPagoTpreng> SaPagoTpreng { get; set; }
        public virtual ICollection<SaSaldoBanco> SaSaldoBanco { get; set; }
        public virtual ICollection<SaTransferenciaEntreCuentas> SaTransferenciaEntreCuentasCtaComisionNavigation { get; set; }
        public virtual ICollection<SaTransferenciaEntreCuentas> SaTransferenciaEntreCuentasCtaDestinoNavigation { get; set; }
        public virtual ICollection<SaTransferenciaEntreCuentas> SaTransferenciaEntreCuentasCtaOrigenNavigation { get; set; }
    }
}
