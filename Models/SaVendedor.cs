using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaVendedor
    {
        public SaVendedor()
        {
            ParEmp = new HashSet<ParEmp>();
            SaCliente = new HashSet<SaCliente>();
            SaCobro = new HashSet<SaCobro>();
            SaComisionGeneracionCoVenDesdeNavigation = new HashSet<SaComisionGeneracion>();
            SaComisionGeneracionCoVenHastaNavigation = new HashSet<SaComisionGeneracion>();
            SaCotizacionCliente = new HashSet<SaCotizacionCliente>();
            SaDevolucionCliente = new HashSet<SaDevolucionCliente>();
            SaDocumentoVenta = new HashSet<SaDocumentoVenta>();
            SaFacturaVenta = new HashSet<SaFacturaVenta>();
            SaNotaDespachoVenta = new HashSet<SaNotaDespachoVenta>();
            SaNotaEntregaVenta = new HashSet<SaNotaEntregaVenta>();
            SaPedidoVenta = new HashSet<SaPedidoVenta>();
            SaPlantillaVenta = new HashSet<SaPlantillaVenta>();
        }

        public string CoVen { get; set; }
        public string Tipo { get; set; }
        public string VenDes { get; set; }
        public int? Numcom { get; set; }
        public DateTime? Feccom { get; set; }
        public string DisCen { get; set; }
        public string Cedula { get; set; }
        public string Direc1 { get; set; }
        public string Direc2 { get; set; }
        public string Telefonos { get; set; }
        public DateTime FechaReg { get; set; }
        public bool Inactivo { get; set; }
        public decimal Comision { get; set; }
        public string Comentario { get; set; }
        public bool FunCob { get; set; }
        public bool FunVen { get; set; }
        public decimal? Comisionv { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PswM { get; set; }
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
        public string CoZon { get; set; }

        public virtual SaZona CoZonNavigation { get; set; }
        public virtual ICollection<ParEmp> ParEmp { get; set; }
        public virtual ICollection<SaCliente> SaCliente { get; set; }
        public virtual ICollection<SaCobro> SaCobro { get; set; }
        public virtual ICollection<SaComisionGeneracion> SaComisionGeneracionCoVenDesdeNavigation { get; set; }
        public virtual ICollection<SaComisionGeneracion> SaComisionGeneracionCoVenHastaNavigation { get; set; }
        public virtual ICollection<SaCotizacionCliente> SaCotizacionCliente { get; set; }
        public virtual ICollection<SaDevolucionCliente> SaDevolucionCliente { get; set; }
        public virtual ICollection<SaDocumentoVenta> SaDocumentoVenta { get; set; }
        public virtual ICollection<SaFacturaVenta> SaFacturaVenta { get; set; }
        public virtual ICollection<SaNotaDespachoVenta> SaNotaDespachoVenta { get; set; }
        public virtual ICollection<SaNotaEntregaVenta> SaNotaEntregaVenta { get; set; }
        public virtual ICollection<SaPedidoVenta> SaPedidoVenta { get; set; }
        public virtual ICollection<SaPlantillaVenta> SaPlantillaVenta { get; set; }
    }
}
