using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaTraslado
    {
        public SaTraslado()
        {
            SaTrasladoReng = new HashSet<SaTrasladoReng>();
        }

        public string TrasNum { get; set; }
        public string MotivoGlo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Tasa { get; set; }
        public string CoMone { get; set; }
        public string AlmOrig { get; set; }
        public string AlmTmp { get; set; }
        public string AlmDest { get; set; }
        public decimal? MontoDist { get; set; }
        public bool Confirma { get; set; }
        public DateTime FecSal { get; set; }
        public DateTime? FecConf { get; set; }
        public bool Anulado { get; set; }
        public int? SerialesS { get; set; }
        public int? SerialesE { get; set; }
        public int? Numcom { get; set; }
        public DateTime? Feccom { get; set; }
        public string DisCen { get; set; }
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

        public virtual SaAlmacen AlmDestNavigation { get; set; }
        public virtual SaAlmacen AlmOrigNavigation { get; set; }
        public virtual SaAlmacen AlmTmpNavigation { get; set; }
        public virtual SaMoneda CoMoneNavigation { get; set; }
        public virtual ICollection<SaTrasladoReng> SaTrasladoReng { get; set; }
    }
}
