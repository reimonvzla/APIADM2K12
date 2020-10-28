using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaDistribCostoOrigenReng
    {
        public SaDistribCostoOrigenReng()
        {
            SaDistribCostoRelaReng = new HashSet<SaDistribCostoRelaReng>();
        }

        public string DistribNum { get; set; }
        public int RengNum { get; set; }
        public Guid? RowguidComp { get; set; }
        public Guid? RowguidPcom { get; set; }
        public decimal? MontoAp { get; set; }
        public string CoIncoterm { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
        public Guid RowguidCalculado { get; set; }

        public virtual SaIncoterm CoIncotermNavigation { get; set; }
        public virtual SaDistribCosto DistribNumNavigation { get; set; }
        public virtual SaFacturaCompraReng RowguidCompNavigation { get; set; }
        public virtual SaPlantillaCompraReng RowguidPcomNavigation { get; set; }
        public virtual ICollection<SaDistribCostoRelaReng> SaDistribCostoRelaReng { get; set; }
    }
}
