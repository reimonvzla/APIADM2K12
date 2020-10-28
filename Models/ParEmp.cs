using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class ParEmp
    {
        public ParEmp()
        {
            SaConsecutivo = new HashSet<SaConsecutivo>();
        }

        public string CodEmp { get; set; }
        public int TabNum { get; set; }
        public byte[] Logo { get; set; }
        public DateTime FechaRes { get; set; }
        public string TempChar1 { get; set; }
        public string TempChar2 { get; set; }
        public string TempChar3 { get; set; }
        public string TempChar4 { get; set; }
        public string TempChar5 { get; set; }
        public string TempChar6 { get; set; }
        public string TempChar7 { get; set; }
        public string TempChar8 { get; set; }
        public DateTime TempFech { get; set; }
        public int TempNum { get; set; }
        public string EmpAdm { get; set; }
        public string EmpCont { get; set; }
        public string EmpNom { get; set; }
        public string UrlservidorwebAdmin { get; set; }
        public string UrlservidorwebCont { get; set; }
        public string UrlservidorwebNom { get; set; }
        public string TipoImpProvExt { get; set; }
        public bool NetTcpAdmin { get; set; }
        public bool NetTcpCont { get; set; }
        public bool NetTcpNom { get; set; }
        public string LoginAdmin { get; set; }
        public string PasswordAdmin { get; set; }
        public string LoginCont { get; set; }
        public string PasswordCont { get; set; }
        public string LoginNom { get; set; }
        public string PasswordNom { get; set; }
        public DateTime FecCont { get; set; }
        public string CoCueAju { get; set; }
        public int Tempor1 { get; set; }
        public string GMoneda { get; set; }
        public bool GMostrarModelo { get; set; }
        public int GAlertaF { get; set; }
        public bool PDescArt { get; set; }
        public bool PDescCat { get; set; }
        public bool PDescGlo { get; set; }
        public bool PDescLin { get; set; }
        public bool VRedondeo { get; set; }
        public int VTipoRedondeo { get; set; }
        public string VValorRedondeo { get; set; }
        public bool CRedondeo { get; set; }
        public int CTipoRedondeo { get; set; }
        public string CValorRedondeo { get; set; }
        public bool VManejaSucursales { get; set; }
        public bool VConceptoDespacho { get; set; }
        public bool VManejoDireccionEntrega { get; set; }
        public string VTipCli { get; set; }
        public string VCoVen { get; set; }
        public string VCondPago { get; set; }
        public string VCtaIngEgr { get; set; }
        public string VCoSeg { get; set; }
        public string VCoZon { get; set; }
        public string VTipoPer { get; set; }
        public bool IStockNegativoAdvertencia { get; set; }
        public bool IStockNegativo { get; set; }
        public int IDecStock { get; set; }
        public int IDecCosto { get; set; }
        public int IDecPrecio { get; set; }
        public bool IMultipleMoneda { get; set; }
        public string IMonedaArticulo { get; set; }
        public bool ISerialesArticulo { get; set; }
        public bool ILicores { get; set; }
        public int ITipoCostDev { get; set; }
        public bool IManejaLotesVencidos { get; set; }
        public int ICostoInventario { get; set; }
        public bool IPermitirFecMenorUltInv { get; set; }
        public int? IManejoArtComp { get; set; }
        public bool CMargenCostoPrecio { get; set; }
        public string CTipPro { get; set; }
        public string CCondPago { get; set; }
        public string CCtaIngEgr { get; set; }
        public string CCoSeg { get; set; }
        public string CCoZon { get; set; }
        public string CTipoPer { get; set; }
        public bool CbCancCompOrdPag { get; set; }
        public bool CbManejImpTran { get; set; }
        public bool CbImpreFis { get; set; }
        public int VMaxReng { get; set; }
        public bool VMaxRengTodos { get; set; }
        public bool LotesDespacho { get; set; }
        public bool SerialesDespacho { get; set; }
        public string Format1 { get; set; }
        public string Format2 { get; set; }
        public string Format3 { get; set; }
        public string Format4 { get; set; }
        public string Format5 { get; set; }
        public string CoSucur { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid? Rowguid { get; set; }
        public byte[] Validador { get; set; }
        public bool? ImpVend { get; set; }
        public bool? ImpTurno { get; set; }
        public bool? ImpNumfac { get; set; }
        public bool? ImpCaja { get; set; }
        public bool? ImpSuc { get; set; }
        public bool? ImpCajero { get; set; }
        public string CCoPais { get; set; }
        public string VCoPais { get; set; }
        public bool CbSujtReten { get; set; }
        public decimal CbReten { get; set; }
        public string TipoImagen { get; set; }
        public int? TamañoImagen { get; set; }
        public string CoUniPeso { get; set; }
        public string CoUniVolumen { get; set; }
        public int? CRetenAuto { get; set; }
        public string Correoservidor { get; set; }
        public string Correodir { get; set; }
        public bool Correossl { get; set; }
        public int Correopuerto { get; set; }
        public short CorreometodoEnt { get; set; }
        public short CorreotiempoExp { get; set; }
        public bool CorreocredencialDef { get; set; }
        public string Correousuario { get; set; }
        public string Correopass { get; set; }
        public int? CRetenIslrAuto { get; set; }
        public bool VReconv { get; set; }
        public bool VManejaNcf { get; set; }
        public string PtoEmision { get; set; }
        public string AreaImp { get; set; }

        public virtual SaSegmento CCoSegNavigation { get; set; }
        public virtual SaZona CCoZonNavigation { get; set; }
        public virtual SaCondicionPago CCondPagoNavigation { get; set; }
        public virtual SaCuentaIngEgr CCtaIngEgrNavigation { get; set; }
        public virtual SaTipoProveedor CTipProNavigation { get; set; }
        public virtual SaUnidad CoUniPesoNavigation { get; set; }
        public virtual SaUnidad CoUniVolumenNavigation { get; set; }
        public virtual SaSegmento VCoSegNavigation { get; set; }
        public virtual SaVendedor VCoVenNavigation { get; set; }
        public virtual SaZona VCoZonNavigation { get; set; }
        public virtual SaCondicionPago VCondPagoNavigation { get; set; }
        public virtual SaCuentaIngEgr VCtaIngEgrNavigation { get; set; }
        public virtual SaTipoCliente VTipCliNavigation { get; set; }
        public virtual ICollection<SaConsecutivo> SaConsecutivo { get; set; }
    }
}
