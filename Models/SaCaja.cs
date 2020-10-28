using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaCaja
    {
        public SaCaja()
        {
            PvParEmp = new HashSet<PvParEmp>();
            PvTurnoExe = new HashSet<PvTurnoExe>();
            SaCobroTpreng = new HashSet<SaCobroTpreng>();
            SaDepositoBanco = new HashSet<SaDepositoBanco>();
            SaDepositoBancoReng = new HashSet<SaDepositoBancoReng>();
            SaMovimientoCaja = new HashSet<SaMovimientoCaja>();
            SaOrdenPago = new HashSet<SaOrdenPago>();
            SaPagoTpreng = new HashSet<SaPagoTpreng>();
            SaSaldoCaja = new HashSet<SaSaldoCaja>();
        }

        public string CodCaja { get; set; }
        public string Descrip { get; set; }
        public DateTime MesIni { get; set; }
        public string CoMone { get; set; }
        public int? Numcom { get; set; }
        public DateTime? Feccom { get; set; }
        public string DisCen { get; set; }
        public bool Inactivo { get; set; }
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

        public virtual SaMoneda CoMoneNavigation { get; set; }
        public virtual PvCaja PvCaja { get; set; }
        public virtual ICollection<PvParEmp> PvParEmp { get; set; }
        public virtual ICollection<PvTurnoExe> PvTurnoExe { get; set; }
        public virtual ICollection<SaCobroTpreng> SaCobroTpreng { get; set; }
        public virtual ICollection<SaDepositoBanco> SaDepositoBanco { get; set; }
        public virtual ICollection<SaDepositoBancoReng> SaDepositoBancoReng { get; set; }
        public virtual ICollection<SaMovimientoCaja> SaMovimientoCaja { get; set; }
        public virtual ICollection<SaOrdenPago> SaOrdenPago { get; set; }
        public virtual ICollection<SaPagoTpreng> SaPagoTpreng { get; set; }
        public virtual ICollection<SaSaldoCaja> SaSaldoCaja { get; set; }
    }
}
