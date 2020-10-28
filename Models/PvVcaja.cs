using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class PvVcaja
    {
        public string CodCaja { get; set; }
        public string Descrip { get; set; }
        public DateTime MesIni { get; set; }
        public string CoMone { get; set; }
        public int? Numcom { get; set; }
        public DateTime? Feccom { get; set; }
        public string DisCen { get; set; }
        public bool Inactivo { get; set; }
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
        public decimal? AuxImp01 { get; set; }
        public decimal? AuxImp02 { get; set; }
        public bool? Mvisa { get; set; }
        public int? Vpostipo { get; set; }
        public string Puerto { get; set; }
        public string Puerto2 { get; set; }
        public bool? Sidisplay { get; set; }
        public bool? Gavetaser { get; set; }
    }
}
