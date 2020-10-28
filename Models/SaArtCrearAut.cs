using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtCrearAut
    {
        public string CoArtCrearAut { get; set; }
        public DateTime FechaReg { get; set; }
        public string ArtCrearAutDes { get; set; }
        public string ArtDes { get; set; }
        public string Tipo { get; set; }
        public string CoLinDesde { get; set; }
        public string CoLinHasta { get; set; }
        public string CoSublDesde { get; set; }
        public string CoSublHasta { get; set; }
        public string CoCatDesde { get; set; }
        public string CoCatHasta { get; set; }
        public string CoColorDesde { get; set; }
        public string CoColorHasta { get; set; }
        public string CoUbicacionDesde { get; set; }
        public string CoUbicacionHasta { get; set; }
        public string CoProcDesde { get; set; }
        public string CoProcHasta { get; set; }
        public string ItemDesde { get; set; }
        public string ItemHasta { get; set; }
        public string CoUni { get; set; }
        public bool UsarCodArtLin { get; set; }
        public int? LongCodArtLin { get; set; }
        public int? OrdenCodArtLin { get; set; }
        public bool UsarCodArtSubl { get; set; }
        public int? LongCodArtSubl { get; set; }
        public int? OrdenCodArtSubl { get; set; }
        public bool UsarCodArtCat { get; set; }
        public int? LongCodArtCat { get; set; }
        public int? OrdenCodArtCat { get; set; }
        public bool UsarCodArtColor { get; set; }
        public int? LongCodArtColor { get; set; }
        public int? OrdenCodArtColor { get; set; }
        public bool UsarCodArtUbicacion { get; set; }
        public int? LongCodArtUbicacion { get; set; }
        public int? OrdenCodArtUbicacion { get; set; }
        public bool UsarCodArtProc { get; set; }
        public int? LongCodArtProc { get; set; }
        public int? OrdenCodArtProc { get; set; }
        public bool UsarCodArtItem { get; set; }
        public int? LongCodArtItem { get; set; }
        public int? OrdenCodArtItem { get; set; }
        public bool? ManejaSerial { get; set; }
        public bool? ManejaLote { get; set; }
        public bool? ManejaLoteVenc { get; set; }
        public string TipoImp { get; set; }
        public string TipoImp2 { get; set; }
        public string TipoImp3 { get; set; }
        public string CoReten { get; set; }
        public string Garantia { get; set; }
        public decimal? Volumen { get; set; }
        public decimal? Peso { get; set; }
        public decimal? StockMin { get; set; }
        public decimal? StockMax { get; set; }
        public decimal? StockPedido { get; set; }
        public int? DescArtLibre { get; set; }
        public bool? Procesado { get; set; }
        public bool? PrecOm { get; set; }
        public string Comentario { get; set; }
        public string TipoCos { get; set; }
        public string CoAlma { get; set; }
        public string RetenIvaTercero { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string Artcampo1 { get; set; }
        public string Artcampo2 { get; set; }
        public string Artcampo3 { get; set; }
        public string Artcampo4 { get; set; }
        public string Artcampo5 { get; set; }
        public string Artcampo6 { get; set; }
        public string Artcampo7 { get; set; }
        public string Artcampo8 { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime? FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime? FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid? Rowguid { get; set; }

        public virtual SaSubLinea Co { get; set; }
        public virtual SaAlmacen CoAlmaNavigation { get; set; }
        public virtual SaCatArticulo CoCatDesdeNavigation { get; set; }
        public virtual SaCatArticulo CoCatHastaNavigation { get; set; }
        public virtual SaColor CoColorDesdeNavigation { get; set; }
        public virtual SaColor CoColorHastaNavigation { get; set; }
        public virtual SaSubLinea CoNavigation { get; set; }
        public virtual SaProcedencia CoProcDesdeNavigation { get; set; }
        public virtual SaProcedencia CoProcHastaNavigation { get; set; }
        public virtual SaConIslr CoRetenNavigation { get; set; }
        public virtual SaUbicacion CoUbicacionDesdeNavigation { get; set; }
        public virtual SaUbicacion CoUbicacionHastaNavigation { get; set; }
        public virtual SaUnidad CoUniNavigation { get; set; }
        public virtual SaProveedor RetenIvaTerceroNavigation { get; set; }
    }
}
