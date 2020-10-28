using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaIncoterm
    {
        public SaIncoterm()
        {
            SaArtImportacion = new HashSet<SaArtImportacion>();
            SaDistribCostoDestinoReng = new HashSet<SaDistribCostoDestinoReng>();
            SaDistribCostoOrigenReng = new HashSet<SaDistribCostoOrigenReng>();
            SaFacturaCompraImportacion = new HashSet<SaFacturaCompraImportacion>();
        }

        public string CoIncoterm { get; set; }
        public string IncotermDes { get; set; }
        public int Secuencia { get; set; }
        public bool Maritimo { get; set; }
        public bool Aereo { get; set; }
        public bool Terrestre { get; set; }
        public string DescripDetallada { get; set; }
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
        public Guid? Rowguid { get; set; }

        public virtual ICollection<SaArtImportacion> SaArtImportacion { get; set; }
        public virtual ICollection<SaDistribCostoDestinoReng> SaDistribCostoDestinoReng { get; set; }
        public virtual ICollection<SaDistribCostoOrigenReng> SaDistribCostoOrigenReng { get; set; }
        public virtual ICollection<SaFacturaCompraImportacion> SaFacturaCompraImportacion { get; set; }
    }
}
