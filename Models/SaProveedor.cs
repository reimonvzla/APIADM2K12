using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaProveedor
    {
        public SaProveedor()
        {
            InverseMatrizNavigation = new HashSet<SaProveedor>();
            SaArtProveedorReng = new HashSet<SaArtProveedorReng>();
            SaArticulo = new HashSet<SaArticulo>();
            SaChequeDevueltoCompra = new HashSet<SaChequeDevueltoCompra>();
            SaCotizacionProveedor = new HashSet<SaCotizacionProveedor>();
            SaDevolucionProveedor = new HashSet<SaDevolucionProveedor>();
            SaDocumentoCompraCoProvNavigation = new HashSet<SaDocumentoCompra>();
            SaDocumentoCompraProvTerNavigation = new HashSet<SaDocumentoCompra>();
            SaDocumentoElectronicoCoProvDesdeNavigation = new HashSet<SaDocumentoElectronico>();
            SaDocumentoElectronicoCoProvHastaNavigation = new HashSet<SaDocumentoElectronico>();
            SaFacturaCompra = new HashSet<SaFacturaCompra>();
            SaNotaRecepcionCompra = new HashSet<SaNotaRecepcionCompra>();
            SaOrdenCompra = new HashSet<SaOrdenCompra>();
            SaPago = new HashSet<SaPago>();
            SaPagoDocReng = new HashSet<SaPagoDocReng>();
            SaPlantillaCompra = new HashSet<SaPlantillaCompra>();
        }

        public string CoProv { get; set; }
        public string ProvDes { get; set; }
        public string CoSeg { get; set; }
        public string CoZon { get; set; }
        public string TipPro { get; set; }
        public bool Inactivo { get; set; }
        public string Direc1 { get; set; }
        public string Direc2 { get; set; }
        public string Telefonos { get; set; }
        public string Fax { get; set; }
        public string Respons { get; set; }
        public DateTime FechaReg { get; set; }
        public decimal MontCre { get; set; }
        public string CoMone { get; set; }
        public string CondPag { get; set; }
        public int PlazPag { get; set; }
        public decimal DescPpago { get; set; }
        public decimal DescGlob { get; set; }
        public string Rif { get; set; }
        public bool Nacional { get; set; }
        public int? Numcom { get; set; }
        public DateTime? Feccom { get; set; }
        public string DisCen { get; set; }
        public string Nit { get; set; }
        public string Email { get; set; }
        public string CoCtaIngrEgr { get; set; }
        public string Comentario { get; set; }
        public int TipoAdi { get; set; }
        public string Matriz { get; set; }
        public string CoTab { get; set; }
        public string TipoPer { get; set; }
        public string CoPais { get; set; }
        public string Ciudad { get; set; }
        public string Zip { get; set; }
        public string Website { get; set; }
        public string Formtype { get; set; }
        public string Taxid { get; set; }
        public bool ContribuE { get; set; }
        public bool ReteRegisDoc { get; set; }
        public decimal PorcEsp { get; set; }
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
        public string EmailAlterno { get; set; }
        public bool SujetoObjRetenIslrAuto { get; set; }

        public virtual SaCuentaIngEgr CoCtaIngrEgrNavigation { get; set; }
        public virtual SaMoneda CoMoneNavigation { get; set; }
        public virtual SaPais CoPaisNavigation { get; set; }
        public virtual SaSegmento CoSegNavigation { get; set; }
        public virtual SaTabuladorIslr CoTabNavigation { get; set; }
        public virtual SaZona CoZonNavigation { get; set; }
        public virtual SaCondicionPago CondPagNavigation { get; set; }
        public virtual SaProveedor MatrizNavigation { get; set; }
        public virtual SaTipoProveedor TipProNavigation { get; set; }
        public virtual ICollection<SaProveedor> InverseMatrizNavigation { get; set; }
        public virtual ICollection<SaArtProveedorReng> SaArtProveedorReng { get; set; }
        public virtual ICollection<SaArticulo> SaArticulo { get; set; }
        public virtual ICollection<SaChequeDevueltoCompra> SaChequeDevueltoCompra { get; set; }
        public virtual ICollection<SaCotizacionProveedor> SaCotizacionProveedor { get; set; }
        public virtual ICollection<SaDevolucionProveedor> SaDevolucionProveedor { get; set; }
        public virtual ICollection<SaDocumentoCompra> SaDocumentoCompraCoProvNavigation { get; set; }
        public virtual ICollection<SaDocumentoCompra> SaDocumentoCompraProvTerNavigation { get; set; }
        public virtual ICollection<SaDocumentoElectronico> SaDocumentoElectronicoCoProvDesdeNavigation { get; set; }
        public virtual ICollection<SaDocumentoElectronico> SaDocumentoElectronicoCoProvHastaNavigation { get; set; }
        public virtual ICollection<SaFacturaCompra> SaFacturaCompra { get; set; }
        public virtual ICollection<SaNotaRecepcionCompra> SaNotaRecepcionCompra { get; set; }
        public virtual ICollection<SaOrdenCompra> SaOrdenCompra { get; set; }
        public virtual ICollection<SaPago> SaPago { get; set; }
        public virtual ICollection<SaPagoDocReng> SaPagoDocReng { get; set; }
        public virtual ICollection<SaPlantillaCompra> SaPlantillaCompra { get; set; }
    }
}
