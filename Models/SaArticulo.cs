using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArticulo
    {
        public SaArticulo()
        {
            SaArtImagen = new HashSet<SaArtImagen>();
            SaArtImportacion = new HashSet<SaArtImportacion>();
            SaArtMargen = new HashSet<SaArtMargen>();
            SaArtPrecio = new HashSet<SaArtPrecio>();
            SaArtProveedorReng = new HashSet<SaArtProveedorReng>();
            SaArtRelacionadoRengCoArtNavigation = new HashSet<SaArtRelacionadoReng>();
            SaArtRelacionadoRengCodRelacNavigation = new HashSet<SaArtRelacionadoReng>();
            SaArtUbicacion = new HashSet<SaArtUbicacion>();
            SaArtUnidad = new HashSet<SaArtUnidad>();
            SaComisionGeneracionCoArtDesdeNavigation = new HashSet<SaComisionGeneracion>();
            SaComisionGeneracionCoArtHastaNavigation = new HashSet<SaComisionGeneracion>();
            SaComisionPrecioArticulo = new HashSet<SaComisionPrecioArticulo>();
            SaComisionRentabArticulo = new HashSet<SaComisionRentabArticulo>();
            SaCostoHistoricoEntrada = new HashSet<SaCostoHistoricoEntrada>();
            SaCostoHistoricoSalida = new HashSet<SaCostoHistoricoSalida>();
            SaDescArticulo = new HashSet<SaDescArticulo>();
            SaLoteEntrada = new HashSet<SaLoteEntrada>();
            SaLoteSalida = new HashSet<SaLoteSalida>();
            SaSeriales = new HashSet<SaSeriales>();
            SaStockAlmacen = new HashSet<SaStockAlmacen>();
        }

        public string CoArt { get; set; }
        public DateTime FechaReg { get; set; }
        public string ArtDes { get; set; }
        public string Tipo { get; set; }
        public bool Anulado { get; set; }
        public DateTime? FechaInac { get; set; }
        public string CoLin { get; set; }
        public string CoSubl { get; set; }
        public string CoCat { get; set; }
        public string CoColor { get; set; }
        public string CoUbicacion { get; set; }
        public string CodProc { get; set; }
        public string Item { get; set; }
        public string Modelo { get; set; }
        public string Ref { get; set; }
        public bool Generico { get; set; }
        public bool ManejaSerial { get; set; }
        public bool ManejaLote { get; set; }
        public bool ManejaLoteVenc { get; set; }
        public decimal MargenMin { get; set; }
        public decimal MargenMax { get; set; }
        public string TipoImp { get; set; }
        public string TipoImp2 { get; set; }
        public string TipoImp3 { get; set; }
        public string CoReten { get; set; }
        public string Garantia { get; set; }
        public decimal Volumen { get; set; }
        public decimal Peso { get; set; }
        public decimal StockMin { get; set; }
        public decimal StockMax { get; set; }
        public decimal StockPedido { get; set; }
        public int RelacUnidad { get; set; }
        public decimal PuntVen { get; set; }
        public decimal PuntCli { get; set; }
        public decimal LicMonIlc { get; set; }
        public decimal LicCapacidad { get; set; }
        public decimal LicGradoAl { get; set; }
        public string LicTipo { get; set; }
        public bool PrecOm { get; set; }
        public string Comentario { get; set; }
        public string TipoCos { get; set; }
        public decimal PorcMargenMinimo { get; set; }
        public decimal PorcMargenMaximo { get; set; }
        public decimal MontComi { get; set; }
        public decimal PorcArancel { get; set; }
        public int? Numcom { get; set; }
        public DateTime? Feccom { get; set; }
        public string DisCen { get; set; }
        public string RetenIvaTercero { get; set; }
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

        public virtual SaSubLinea Co { get; set; }
        public virtual SaCatArticulo CoCatNavigation { get; set; }
        public virtual SaColor CoColorNavigation { get; set; }
        public virtual SaConIslr CoRetenNavigation { get; set; }
        public virtual SaUbicacion CoUbicacionNavigation { get; set; }
        public virtual SaProcedencia CodProcNavigation { get; set; }
        public virtual SaProveedor RetenIvaTerceroNavigation { get; set; }
        public virtual PvArticuloExt PvArticuloExt { get; set; }
        public virtual SaArtCaracteristica SaArtCaracteristica { get; set; }
        public virtual ICollection<SaArtImagen> SaArtImagen { get; set; }
        public virtual ICollection<SaArtImportacion> SaArtImportacion { get; set; }
        public virtual ICollection<SaArtMargen> SaArtMargen { get; set; }
        public virtual ICollection<SaArtPrecio> SaArtPrecio { get; set; }
        public virtual ICollection<SaArtProveedorReng> SaArtProveedorReng { get; set; }
        public virtual ICollection<SaArtRelacionadoReng> SaArtRelacionadoRengCoArtNavigation { get; set; }
        public virtual ICollection<SaArtRelacionadoReng> SaArtRelacionadoRengCodRelacNavigation { get; set; }
        public virtual ICollection<SaArtUbicacion> SaArtUbicacion { get; set; }
        public virtual ICollection<SaArtUnidad> SaArtUnidad { get; set; }
        public virtual ICollection<SaComisionGeneracion> SaComisionGeneracionCoArtDesdeNavigation { get; set; }
        public virtual ICollection<SaComisionGeneracion> SaComisionGeneracionCoArtHastaNavigation { get; set; }
        public virtual ICollection<SaComisionPrecioArticulo> SaComisionPrecioArticulo { get; set; }
        public virtual ICollection<SaComisionRentabArticulo> SaComisionRentabArticulo { get; set; }
        public virtual ICollection<SaCostoHistoricoEntrada> SaCostoHistoricoEntrada { get; set; }
        public virtual ICollection<SaCostoHistoricoSalida> SaCostoHistoricoSalida { get; set; }
        public virtual ICollection<SaDescArticulo> SaDescArticulo { get; set; }
        public virtual ICollection<SaLoteEntrada> SaLoteEntrada { get; set; }
        public virtual ICollection<SaLoteSalida> SaLoteSalida { get; set; }
        public virtual ICollection<SaSeriales> SaSeriales { get; set; }
        public virtual ICollection<SaStockAlmacen> SaStockAlmacen { get; set; }
    }
}
