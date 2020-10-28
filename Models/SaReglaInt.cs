using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaReglaInt
    {
        public string CoReg { get; set; }
        public string DesReg { get; set; }
        public string Tipo { get; set; }
        public bool Inactivo { get; set; }
        public int Debehaber { get; set; }
        public string Aplica { get; set; }
        public string Monto { get; set; }
        public string Gasto { get; set; }
        public string Distri { get; set; }
        public string Descrip { get; set; }
        public string Cuenta { get; set; }
        public string Encabezado { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoSucuIn { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoSucuMo { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string Version { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }
    }
}
