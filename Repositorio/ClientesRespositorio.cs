namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class ClientesRespositorio : IRepositorio<SaCliente>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        
        #region Find
        public SaCliente Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaCliente.Select(c => new SaCliente
            {
                #region Campos
                CoCli = c.CoCli,
                TipCli = c.TipCli,
                CliDes = c.CliDes,
                Direc1 = c.Direc1,
                DirEnt2 = c.DirEnt2,
                Direc2 = c.Direc2,
                Telefonos = c.Telefonos,
                Fax = c.Fax,
                Inactivo = c.Inactivo,
                Comentario = c.Comentario,
                Respons = c.Respons,
                FechaReg = c.FechaReg,
                Puntaje = c.Puntaje,
                MontCre = c.MontCre,
                CoMone = c.CoMone,
                CondPag = c.CondPag,
                PlazPag = c.PlazPag,
                DescPpago = c.DescPpago,
                CoZon = c.CoZon,
                CoSeg = c.CoSeg,
                CoVen = c.CoVen,
                DescGlob = c.DescGlob,
                HorarCaja = c.HorarCaja,
                FrecuVist = c.FrecuVist,
                Lunes = c.Lunes,
                Martes = c.Martes,
                Miercoles = c.Miercoles,
                Jueves = c.Jueves,
                Viernes = c.Viernes,
                Sabado = c.Sabado,
                Domingo = c.Domingo,
                Rif = c.Rif,
                Nit = c.Nit,
                Contrib = c.Contrib,
                Numcom = c.Numcom,
                Feccom = c.Feccom,
                DisCen = c.DisCen,
                Email = c.Email,
                CoCtaIngrEgr = c.CoCtaIngrEgr,
                Juridico = c.Juridico,
                TipoAdi = c.TipoAdi,
                Matriz = c.Matriz,
                CoTab = c.CoTab,
                TipoPer = c.TipoPer,
                Valido = c.Valido,
                Ciudad = c.Ciudad,
                Zip = c.Zip,
                Login = c.Login,
                Password = c.Password,
                Website = c.Website,
                Sincredito = c.Sincredito,
                ContribuE = c.ContribuE,
                ReteRegisDoc = c.ReteRegisDoc,
                PorcEsp = c.PorcEsp,
                CoPais = c.CoPais,
                Serialp = c.Serialp,
                Id = c.Id,
                Salestax = c.Salestax,
                Estado = c.Estado,
                Campo1 = c.Campo1,
                Campo2 = c.Campo2,
                Campo3 = c.Campo3,
                Campo4 = c.Campo4,
                Campo5 = c.Campo5,
                Campo6 = c.Campo6,
                Campo7 = c.Campo7,
                Campo8 = c.Campo8,
                CoUsIn = c.CoUsIn,
                FeUsIn = c.FeUsIn,
                CoSucuIn = c.CoSucuIn,
                CoUsMo = c.CoUsMo,
                FeUsMo = c.FeUsMo,
                CoSucuMo = c.CoSucuMo,
                Revisado = c.Revisado,
                Trasnfe = c.Trasnfe,
                Validador = c.Validador,
                Rowguid = c.Rowguid,
                EmailAlterno = c.EmailAlterno
                #endregion

            }).FirstOrDefault(c => c.CoCli.Trim() == key.Trim());
        } 
        #endregion

        #region GetAll
        public IEnumerable<SaCliente> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaCliente.Select(c => new SaCliente
            {
                #region Campos
                CoCli = c.CoCli,
                TipCli = c.TipCli,
                CliDes = c.CliDes,
                Direc1 = c.Direc1,
                DirEnt2 = c.DirEnt2,
                Direc2 = c.Direc2,
                Telefonos = c.Telefonos,
                Fax = c.Fax,
                Inactivo = c.Inactivo,
                Comentario = c.Comentario,
                Respons = c.Respons,
                FechaReg = c.FechaReg,
                Puntaje = c.Puntaje,
                MontCre = c.MontCre,
                CoMone = c.CoMone,
                CondPag = c.CondPag,
                PlazPag = c.PlazPag,
                DescPpago = c.DescPpago,
                CoZon = c.CoZon,
                CoSeg = c.CoSeg,
                CoVen = c.CoVen,
                DescGlob = c.DescGlob,
                HorarCaja = c.HorarCaja,
                FrecuVist = c.FrecuVist,
                Lunes = c.Lunes,
                Martes = c.Martes,
                Miercoles = c.Miercoles,
                Jueves = c.Jueves,
                Viernes = c.Viernes,
                Sabado = c.Sabado,
                Domingo = c.Domingo,
                Rif = c.Rif,
                Nit = c.Nit,
                Contrib = c.Contrib,
                Numcom = c.Numcom,
                Feccom = c.Feccom,
                DisCen = c.DisCen,
                Email = c.Email,
                CoCtaIngrEgr = c.CoCtaIngrEgr,
                Juridico = c.Juridico,
                TipoAdi = c.TipoAdi,
                Matriz = c.Matriz,
                CoTab = c.CoTab,
                TipoPer = c.TipoPer,
                Valido = c.Valido,
                Ciudad = c.Ciudad,
                Zip = c.Zip,
                Login = c.Login,
                Password = c.Password,
                Website = c.Website,
                Sincredito = c.Sincredito,
                ContribuE = c.ContribuE,
                ReteRegisDoc = c.ReteRegisDoc,
                PorcEsp = c.PorcEsp,
                CoPais = c.CoPais,
                Serialp = c.Serialp,
                Id = c.Id,
                Salestax = c.Salestax,
                Estado = c.Estado,
                Campo1 = c.Campo1,
                Campo2 = c.Campo2,
                Campo3 = c.Campo3,
                Campo4 = c.Campo4,
                Campo5 = c.Campo5,
                Campo6 = c.Campo6,
                Campo7 = c.Campo7,
                Campo8 = c.Campo8,
                CoUsIn = c.CoUsIn,
                FeUsIn = c.FeUsIn,
                CoSucuIn = c.CoSucuIn,
                CoUsMo = c.CoUsMo,
                FeUsMo = c.FeUsMo,
                CoSucuMo = c.CoSucuMo,
                Revisado = c.Revisado,
                Trasnfe = c.Trasnfe,
                Validador = c.Validador,
                Rowguid = c.Rowguid,
                EmailAlterno = c.EmailAlterno 
                #endregion

            }).ToList();
        } 
        #endregion

        #region Remove
        public Response Remove(string key, string user, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                SaCliente data = Find(key, empresaDB);
                data.Inactivo = true;
                data.CoUsMo = user;
                data.FeUsMo = DateTime.Now;
                db.Entry(data).State = EntityState.Modified;
                db.SaveChanges();
                return new Response { Status = "OK", Message = $"Se inactivó el cliente {data.CoCli.Trim()} {data.CliDes.Trim()} con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }

        }
        #endregion

        #region Save
        public Response Save(SaCliente item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                SaCliente existCliente = Find(item.CoCli, empresaDB);
                if (existCliente != null)
                {
                    throw new ArgumentException($"El codigo cliente '{item.CoCli.Trim()}' se encuentra registrado.");
                }
                else
                {
                    #region Cliente rápido como configuracion de nuevos clientes
                    //ParEmp clienteRapido = db.ParEmp.FirstOrDefault();
                    //if (string.IsNullOrEmpty(clienteRapido.VTipCli)) throw new ArgumentException("No existe configurado el tipo de cliente en parametros de la empresa (Cliente rápido).");
                    //if (string.IsNullOrEmpty(clienteRapido.VCondPago)) throw new ArgumentException("No existe configurado la condicion de pago en parametros de la empresa (Cliente rápido).");
                    //if (string.IsNullOrEmpty(clienteRapido.VCoVen)) throw new ArgumentException("No existe configurado el vendedor en parametros de la empresa (Cliente rápido).");
                    //if (string.IsNullOrEmpty(clienteRapido.VCtaIngEgr)) throw new ArgumentException("No existe configurado la cuenta ingreso/egreso en parametros de la empresa (Cliente rápido).");
                    //if (string.IsNullOrEmpty(clienteRapido.VCoSeg)) throw new ArgumentException("No existe configurado el segmento en parametros de la empresa (Cliente rápido).");
                    //if (string.IsNullOrEmpty(clienteRapido.VCoZon)) throw new ArgumentException("No existe configurado la zona en parametros de la empresa (Cliente rápido).");
                    //if (string.IsNullOrEmpty(clienteRapido.VTipoPer)) throw new ArgumentException("No existe configurado el tipo de persona en parametros de la empresa (Cliente rápido).");
                    #endregion

                    //item.TipCli = clienteRapido.VTipCli;
                    //item.CondPag = clienteRapido.VCondPago;
                    //item.CoVen = clienteRapido.VCoVen;
                    //item.CoCtaIngrEgr = clienteRapido.VCtaIngEgr;
                    //item.CoSeg = clienteRapido.VCoSeg;
                    //item.CoZon = clienteRapido.VCoZon;
                    //item.TipoPer = clienteRapido.VTipoPer;
                    item.FechaReg = DateTime.Now;
                    //item.CoMone =  db.ParEmp.FirstOrDefault().GMoneda;

                    db.Entry(item).State = EntityState.Added;
                    db.SaveChanges();
                    return new Response { Status = "OK", Message = $"Se ha registrado el cliente ID: [{item.CoCli.Trim()}]" };
                }
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(SaCliente item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return new Response { Status = "OK", Message = "Actualización realizada con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion
    
    }
}