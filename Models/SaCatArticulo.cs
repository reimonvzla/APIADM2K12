﻿using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaCatArticulo
    {
        public SaCatArticulo()
        {
            SaArticulo = new HashSet<SaArticulo>();
            SaComisionGeneracionCoCatDesdeNavigation = new HashSet<SaComisionGeneracion>();
            SaComisionGeneracionCoCatHastaNavigation = new HashSet<SaComisionGeneracion>();
            SaComisionPrecioCategoria = new HashSet<SaComisionPrecioCategoria>();
            SaComisionRentabCategoria = new HashSet<SaComisionRentabCategoria>();
            SaDescCategoria = new HashSet<SaDescCategoria>();
        }

        public string CoCat { get; set; }
        public string CatDes { get; set; }
        public string CoImun { get; set; }
        public string CoReten { get; set; }
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }
        public string DisCen { get; set; }
        public bool Movil { get; set; }
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

        public virtual SaConIslr CoRetenNavigation { get; set; }
        public virtual ICollection<SaArticulo> SaArticulo { get; set; }
        public virtual ICollection<SaComisionGeneracion> SaComisionGeneracionCoCatDesdeNavigation { get; set; }
        public virtual ICollection<SaComisionGeneracion> SaComisionGeneracionCoCatHastaNavigation { get; set; }
        public virtual ICollection<SaComisionPrecioCategoria> SaComisionPrecioCategoria { get; set; }
        public virtual ICollection<SaComisionRentabCategoria> SaComisionRentabCategoria { get; set; }
        public virtual ICollection<SaDescCategoria> SaDescCategoria { get; set; }
    }
}
