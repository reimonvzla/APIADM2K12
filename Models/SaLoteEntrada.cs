using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaLoteEntrada
    {
        public SaLoteEntrada()
        {
            SaLoteSalida = new HashSet<SaLoteSalida>();
        }

        public Guid RowguidReng { get; set; }
        public int RengNum { get; set; }
        public string TipoDoc { get; set; }
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public string NumeroLote { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaExpiracion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal StockActual { get; set; }
        public decimal Precio { get; set; }
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

        public virtual SaAlmacen CoAlmaNavigation { get; set; }
        public virtual SaArticulo CoArtNavigation { get; set; }
        public virtual ICollection<SaLoteSalida> SaLoteSalida { get; set; }
    }
}
