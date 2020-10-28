using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaConsultaArticulo
    {
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
        public decimal MontComi { get; set; }
        public decimal PorcArancel { get; set; }
        public string DisCen { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public Guid Rowguid { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUni { get; set; }
        public string ScoUni { get; set; }
    }
}
