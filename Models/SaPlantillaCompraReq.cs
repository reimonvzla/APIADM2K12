using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaPlantillaCompraReq
    {
        public Guid RowguidPlantillaCompra { get; set; }
        public string CoUbicacion { get; set; }
        public string Autorizado { get; set; }
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public string Email { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estatus { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
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

        public virtual SaUbicacion CoUbicacionNavigation { get; set; }
        public virtual SaPlantillaCompra RowguidPlantillaCompraNavigation { get; set; }
    }
}
