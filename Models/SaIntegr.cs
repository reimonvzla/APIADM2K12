using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaIntegr
    {
        public string InteNum { get; set; }
        public DateTime? FecEmis { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }
        public string DesInte { get; set; }
        public bool Docnoint { get; set; }
        public bool Marcar { get; set; }
        public bool ValCuad { get; set; }
        public bool Compxfec { get; set; }
        public bool Compxtip { get; set; }
        public int Criterio { get; set; }
        public int Agrupam { get; set; }
        public bool Compras { get; set; }
        public bool Pagos { get; set; }
        public bool DevPro { get; set; }
        public bool NcrPro { get; set; }
        public bool NdbPro { get; set; }
        public bool GirPro { get; set; }
        public bool ChdevPro { get; set; }
        public bool Ventas { get; set; }
        public bool Cobros { get; set; }
        public bool DevCli { get; set; }
        public bool NcrCli { get; set; }
        public bool NdbCli { get; set; }
        public bool GirCli { get; set; }
        public bool ChdevCli { get; set; }
        public bool OrdPago { get; set; }
        public bool MovCaja { get; set; }
        public bool MovBanco { get; set; }
        public bool Ajustes { get; set; }
        public bool NotEnt { get; set; }
        public bool ComGen { get; set; }
        public bool Nomina { get; set; }
        public bool NotRec { get; set; }
        public bool Todos { get; set; }
        public bool ActUltf { get; set; }
        public bool Placom { get; set; }
        public bool Plavent { get; set; }
        public bool Ajupr { get; set; }
        public bool Ajucl { get; set; }
        public bool TrasAlm { get; set; }
        public bool Pedidos { get; set; }
        public bool Ordenes { get; set; }
        public string CoSucuDesde { get; set; }
        public string CoSucuHasta { get; set; }
        public string CoContDesde { get; set; }
        public string CoContHasta { get; set; }
        public bool Ajustexdif { get; set; }
        public int Orden { get; set; }
        public bool AuxiliarNom { get; set; }
        public string CoSucuIn { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoSucuMo { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaSucursal CoSucuDesdeNavigation { get; set; }
        public virtual SaSucursal CoSucuHastaNavigation { get; set; }
    }
}
