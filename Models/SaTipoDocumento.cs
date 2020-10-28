using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaTipoDocumento
    {
        public SaTipoDocumento()
        {
            SaDocumentoCompraCoTipoDocNavigation = new HashSet<SaDocumentoCompra>();
            SaDocumentoCompraDocOrigNavigation = new HashSet<SaDocumentoCompra>();
            SaDocumentoVentaCoTipoDocNavigation = new HashSet<SaDocumentoVenta>();
            SaDocumentoVentaDocOrigNavigation = new HashSet<SaDocumentoVenta>();
        }

        public string CoTipoDoc { get; set; }
        public string Descrip { get; set; }
        public string TipoMov { get; set; }
        public bool UsarVentas { get; set; }
        public bool UsarCompras { get; set; }
        public bool RegistroSistema { get; set; }
        public bool NumFactFisVenta { get; set; }
        public bool NumContVenta { get; set; }
        public bool SerialImpFisVenta { get; set; }
        public bool RengVenta { get; set; }
        public bool NumIvaVenta { get; set; }
        public bool ReacDocCompra { get; set; }
        public bool ReacDocVenta { get; set; }
        public bool AnulDocVenta { get; set; }
        public bool AnulDocCompra { get; set; }
        public bool DocProvCompra { get; set; }
        public bool NumControlCompra { get; set; }
        public bool RengCompra { get; set; }
        public bool NumIvaCompra { get; set; }
        public bool ManualVenta { get; set; }
        public bool ManualCompra { get; set; }
        public bool DocAsocCompra { get; set; }
        public bool DocAsocVenta { get; set; }
        public bool ActProgPago { get; set; }
        public bool AplicaDxppVenta { get; set; }
        public bool AplicaDxppCompra { get; set; }
        public bool AplicaRivaVenta { get; set; }
        public bool AplicaRivaCompra { get; set; }
        public string TipoImp { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public byte[] Validador { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<SaDocumentoCompra> SaDocumentoCompraCoTipoDocNavigation { get; set; }
        public virtual ICollection<SaDocumentoCompra> SaDocumentoCompraDocOrigNavigation { get; set; }
        public virtual ICollection<SaDocumentoVenta> SaDocumentoVentaCoTipoDocNavigation { get; set; }
        public virtual ICollection<SaDocumentoVenta> SaDocumentoVentaDocOrigNavigation { get; set; }
    }
}
