using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaCostoHistoricoEntrada
    {
        public SaCostoHistoricoEntrada()
        {
            SaCostoHistoricoSalida = new HashSet<SaCostoHistoricoSalida>();
        }

        public Guid CodCostoHistoricoEntrada { get; set; }
        public Guid CodArticuloRowguid { get; set; }
        public string CodAlmacen { get; set; }
        public string TipoDoc { get; set; }
        public Guid DocOrig { get; set; }
        public Guid? CodCostoHistoricoSalidaOrig { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadUsada { get; set; }
        public decimal Costo { get; set; }
        public decimal CostoPro { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public int RengNum { get; set; }
        public byte[] Validador { get; set; }

        public virtual SaAlmacen CodAlmacenNavigation { get; set; }
        public virtual SaArticulo CodArticuloRowgu { get; set; }
        public virtual SaCostoHistoricoSalida CodCostoHistoricoSalidaOrigNavigation { get; set; }
        public virtual ICollection<SaCostoHistoricoSalida> SaCostoHistoricoSalida { get; set; }
    }
}
