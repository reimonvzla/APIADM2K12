using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaCostoHistoricoSalida
    {
        public SaCostoHistoricoSalida()
        {
            SaCostoHistoricoEntrada = new HashSet<SaCostoHistoricoEntrada>();
        }

        public Guid CodCostoHistoricoSalida { get; set; }
        public Guid? CodCostoHistoricoEntrada { get; set; }
        public Guid CodArticuloRowguid { get; set; }
        public Guid DocOrig { get; set; }
        public decimal CostoPro { get; set; }
        public decimal Cantidad { get; set; }
        public string TipoDoc { get; set; }
        public byte[] Validador { get; set; }
        public DateTime FechaEmision { get; set; }
        public string CodAlmacen { get; set; }

        public virtual SaAlmacen CodAlmacenNavigation { get; set; }
        public virtual SaArticulo CodArticuloRowgu { get; set; }
        public virtual SaCostoHistoricoEntrada CodCostoHistoricoEntradaNavigation { get; set; }
        public virtual ICollection<SaCostoHistoricoEntrada> SaCostoHistoricoEntrada { get; set; }
    }
}
