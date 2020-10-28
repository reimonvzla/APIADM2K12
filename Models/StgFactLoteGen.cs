using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class StgFactLoteGen
    {
        public StgFactLoteGen()
        {
            StgFacturaVentaExt = new HashSet<StgFacturaVentaExt>();
        }

        public string CoFactLoteGen { get; set; }
        public string Descrip { get; set; }
        public DateTime Fecha { get; set; }
        public bool Procesado { get; set; }
        public string CoCliD { get; set; }
        public string CoCliH { get; set; }
        public string CoSerieFact { get; set; }
        public string CoSerieNctrl { get; set; }
        public bool ManVenPl { get; set; }
        public bool ManCondPl { get; set; }
        public DateTime FecEmis { get; set; }
        public DateTime FecVenc { get; set; }
        public DateTime FecReg { get; set; }
        public bool ManFecEmis { get; set; }
        public bool ManFecVenc { get; set; }
        public bool ManFecReg { get; set; }
        public bool PrecVtaAct { get; set; }
        public string CoUsuario { get; set; }
        public string CoSucu { get; set; }
        public string CoPlanVta { get; set; }
        public string SpUsuario { get; set; }
        public string ArchCod { get; set; }
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

        public virtual SaCliente CoCl { get; set; }
        public virtual SaCliente CoCliHNavigation { get; set; }
        public virtual SaPlantillaVenta CoPlanVtaNavigation { get; set; }
        public virtual SaSerie CoSerieFactNavigation { get; set; }
        public virtual SaSerie CoSerieNctrlNavigation { get; set; }
        public virtual ICollection<StgFacturaVentaExt> StgFacturaVentaExt { get; set; }
    }
}
