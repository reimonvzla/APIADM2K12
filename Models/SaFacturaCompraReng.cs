using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaFacturaCompraReng
    {
        public SaFacturaCompraReng()
        {
            SaDistribCostoDestinoReng = new HashSet<SaDistribCostoDestinoReng>();
            SaDistribCostoOrigenReng = new HashSet<SaDistribCostoOrigenReng>();
        }

        public int RengNum { get; set; }
        public string DocNum { get; set; }
        public string CoArt { get; set; }
        public string DesArt { get; set; }
        public string CoUni { get; set; }
        public string ScoUni { get; set; }
        public string CoAlma { get; set; }
        public string TipoImp { get; set; }
        public string TipoImp2 { get; set; }
        public string TipoImp3 { get; set; }
        public string TipoDoc { get; set; }
        public string PorcDesc { get; set; }
        public string NumDoc { get; set; }
        public Guid? RowguidDoc { get; set; }
        public decimal RengNeto { get; set; }
        public decimal CostUnit { get; set; }
        public decimal CostUnitOm { get; set; }
        public decimal TotalArt { get; set; }
        public decimal StotalArt { get; set; }
        public decimal Otros { get; set; }
        public decimal PorcImp { get; set; }
        public decimal PorcImp2 { get; set; }
        public decimal PorcImp3 { get; set; }
        public decimal MontoImp { get; set; }
        public decimal MontoImp2 { get; set; }
        public decimal MontoImp3 { get; set; }
        public decimal PorcGas { get; set; }
        public decimal TotalDev { get; set; }
        public decimal MontoDev { get; set; }
        public bool LoteAsignado { get; set; }
        public decimal MontoDescGlob { get; set; }
        public decimal MontoRecaGlob { get; set; }
        public decimal Otros1Glob { get; set; }
        public decimal Otros2Glob { get; set; }
        public decimal Otros3Glob { get; set; }
        public decimal MontoImpAfecGlob { get; set; }
        public decimal MontoImp2AfecGlob { get; set; }
        public decimal MontoImp3AfecGlob { get; set; }
        public decimal MontoDesc { get; set; }
        public decimal Pendiente { get; set; }
        public decimal Pendiente2 { get; set; }
        public string Comentario { get; set; }
        public decimal CostoAdi1 { get; set; }
        public decimal CostoAdi2 { get; set; }
        public decimal CostoAdi3 { get; set; }
        public string DisCen { get; set; }
        public string CoSucuIn { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoSucuMo { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaArtUnidad Co { get; set; }
        public virtual SaAlmacen CoAlmaNavigation { get; set; }
        public virtual SaFacturaCompra DocNumNavigation { get; set; }
        public virtual SaArtUnidad SaArtUnidad { get; set; }
        public virtual SaDatosDeImportacion SaDatosDeImportacion { get; set; }
        public virtual SaFactCompRengCaracteristicasAdic SaFactCompRengCaracteristicasAdic { get; set; }
        public virtual SaFactCompRengPesoVolumen SaFactCompRengPesoVolumen { get; set; }
        public virtual SaFacturaCompraRengExt SaFacturaCompraRengExt { get; set; }
        public virtual ICollection<SaDistribCostoDestinoReng> SaDistribCostoDestinoReng { get; set; }
        public virtual ICollection<SaDistribCostoOrigenReng> SaDistribCostoOrigenReng { get; set; }
    }
}
