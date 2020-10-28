using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaConciliacionDetalle
    {
        public SaConciliacionDetalle()
        {
            SaConcBanco = new HashSet<SaConcBanco>();
        }

        public string CoAutoCon { get; set; }
        public int RengNum { get; set; }
        public DateTime FecMov { get; set; }
        public string DocNum { get; set; }
        public string TipoOp { get; set; }
        public string Descrip { get; set; }
        public decimal MontoD { get; set; }
        public decimal MontoH { get; set; }
        public decimal Idb { get; set; }
        public string Origen { get; set; }
        public bool DepCon { get; set; }
        public bool Repetido { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaConciliacionAutoReng CoAutoConNavigation { get; set; }
        public virtual ICollection<SaConcBanco> SaConcBanco { get; set; }
    }
}
