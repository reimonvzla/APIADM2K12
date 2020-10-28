using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaGiroVenta
    {
        public SaGiroVenta()
        {
            SaGiroVentaReng = new HashSet<SaGiroVentaReng>();
        }

        public string CoGiro { get; set; }
        public string DesGiro { get; set; }
        public string CoCli { get; set; }
        public string CoVen { get; set; }
        public DateTime Fecha { get; set; }
        public int CantGiro { get; set; }
        public string Frecuencia { get; set; }
        public DateTime FecPGiro { get; set; }
        public decimal PorcInteres { get; set; }
        public string CobNum { get; set; }
        public string CoTipoDoc { get; set; }
        public string NroDoc { get; set; }
        public decimal MontDoc { get; set; }
        public bool Procesado { get; set; }
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

        public virtual ICollection<SaGiroVentaReng> SaGiroVentaReng { get; set; }
    }
}
