using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaAjPrecioCostoAuto
    {
        public string CodAjuste { get; set; }
        public string DesAjuste { get; set; }
        public string CoAlma { get; set; }
        public int TipoAjuste { get; set; }
        public string TipoAjustePrecio { get; set; }
        public string TipoAjusteCosto { get; set; }
        public int? Metodo { get; set; }
        public int? TipoCalculo { get; set; }
        public decimal Valor { get; set; }
        public decimal Factor { get; set; }
        public bool Redondeo { get; set; }
        public int? TipoRedondeo { get; set; }
        public string ValorRedondeo { get; set; }
        public string MargenSuperior { get; set; }
        public string MargenInferior { get; set; }
        public string Condicion1 { get; set; }
        public string Condicion2 { get; set; }
        public decimal? ValorCondicion1 { get; set; }
        public int? OperadorLogico { get; set; }
        public decimal? ValorCondicion2 { get; set; }
        public string CoArtDesde { get; set; }
        public string CoArtHasta { get; set; }
        public string CoLinDesde { get; set; }
        public string CoLinHasta { get; set; }
        public string CoSublDesde { get; set; }
        public string CoSublHasta { get; set; }
        public string CoCatDesde { get; set; }
        public string CoCatHasta { get; set; }
        public string CoProvDesde { get; set; }
        public string CoProvHasta { get; set; }
        public string ItemDesde { get; set; }
        public string ItemHasta { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public bool BasadoEn { get; set; }
        public string BasadoEnCosto { get; set; }
        public DateTime? BasadoEnFecha { get; set; }
        public string BasadoEnCoAlma { get; set; }
        public bool Procesado { get; set; }
        public DateTime? Fecha { get; set; }
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

        public virtual SaAlmacen BasadoEnCoAlmaNavigation { get; set; }
    }
}
