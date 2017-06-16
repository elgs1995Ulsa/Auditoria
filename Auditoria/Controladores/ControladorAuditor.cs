using Auditoria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditoria.Controladores
{
    public static class ControladorAuditor
    {
        public static Modelo.Auditor auditorActivo { get; set; }
        public static Empresa empresaActiva { get; set; }

        public static List<Empresa> seleccionarEmpresas()
        {
            List<Empresa> listaEmpresas = new List<Empresa>();

            try
            {
                AuditoriaModeloDataContext contexto = new AuditoriaModeloDataContext();

                List<AuditorXEmpresa> listaEmpresasAuditadas = contexto.AuditorXEmpresa.Where(axe => axe.idAuditor == auditorActivo.idAuditor).ToList();

                foreach (AuditorXEmpresa axe in listaEmpresasAuditadas)
                {
                    listaEmpresas.Add(axe.Empresa);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return listaEmpresas;
        }

        public static List<AuditoriaRecursosHumanos> seleccionarAuditoriaRecursosHumanos()
        {
            List<AuditoriaRecursosHumanos> lista = new List<AuditoriaRecursosHumanos>();

            try
            {
                AuditoriaModeloDataContext contexto = new AuditoriaModeloDataContext();

                lista = contexto.AuditoriaRecursosHumanos.Where(a => a.idAuditor == auditorActivo.idAuditor && a.idEmpresa == empresaActiva.idEmpresa).ToList();
            }
            catch (Exception) { }

            return lista;
        }

        public static List<AuditoriaCapacitacionYBienestar> seleccionarAuditoriaCapacitacionYBienestar()
        {
            List<AuditoriaCapacitacionYBienestar> lista = new List<AuditoriaCapacitacionYBienestar>();

            try
            {
                AuditoriaModeloDataContext contexto = new AuditoriaModeloDataContext();

                lista = contexto.AuditoriaCapacitacionYBienestar.Where(a => a.idAuditor == auditorActivo.idAuditor && a.idEmpresa == empresaActiva.idEmpresa).ToList();
            }
            catch (Exception) { }

            return lista;
        }

        public static List<AuditoriaRecursosYReclutamiento> seleccionarAuditoriaRecursosYReclutamiento()
        {
            List<AuditoriaRecursosYReclutamiento> lista = new List<AuditoriaRecursosYReclutamiento>();

            try
            {
                AuditoriaModeloDataContext contexto = new AuditoriaModeloDataContext();

                lista = contexto.AuditoriaRecursosYReclutamiento.Where(a => a.idAuditor == auditorActivo.idAuditor && a.idEmpresa == empresaActiva.idEmpresa).ToList();
            }
            catch (Exception) { }

            return lista;
        }

        // INSERTS
        public static bool insertarCuestionarioGeneral(
            int p1,
            int p2,
            int p3,
            int p4,
            int p5,
            int p6,
            int p7,
            int p8,
            int p9,
            int p10,
            string comentario
        ) {
            AuditoriaRecursosHumanos c = null;

            try
            {
                AuditoriaModeloDataContext contexto = new AuditoriaModeloDataContext();

                c = new AuditoriaRecursosHumanos
                {
                    p1 = p1,
                    p2 = p2,
                    p3 = p3,
                    p4 = p4,
                    p5 = p5,
                    p6 = p6,
                    p7 = p7,
                    p8 = p8,
                    p9 = p9,
                    p10 = p10,
                    comentario = DateTime.Now.ToShortDateString() + " - " + comentario,
                    idAuditor = auditorActivo.idAuditor,
                    idEmpresa = empresaActiva.idEmpresa
                };

                contexto.AuditoriaRecursosHumanos.InsertOnSubmit(c);
                contexto.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool insertarCuestionarioRecursosReclutamiento(
            int p1,
            int p2,
            int p3,
            int p4,
            int p5,
            int p6,
            int p7,
            int p8,
            string comentario
        ) {
            AuditoriaRecursosYReclutamiento c = null;

            try
            {
                AuditoriaModeloDataContext contexto = new AuditoriaModeloDataContext();

                c = new AuditoriaRecursosYReclutamiento
                {
                    p1 = p1,
                    p2 = p2,
                    p3 = p3,
                    p4 = p4,
                    p5 = p5,
                    p6 = p6,
                    p7 = p7,
                    p8 = p8,
                    comentario = DateTime.Now.ToShortDateString() + " - " + comentario,
                    idAuditor = auditorActivo.idAuditor,
                    idEmpresa = empresaActiva.idEmpresa
                };

                contexto.AuditoriaRecursosYReclutamiento.InsertOnSubmit(c);
                contexto.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool insertarCuestionarioCapacitacion(
            int p1,
            int p2,
            int p3,
            int p4,
            int p5,
            int p6,
            int p7,
            int p8,
            string comentario
        )
        {
            AuditoriaCapacitacionYBienestar c = null;

            try
            {
                AuditoriaModeloDataContext contexto = new AuditoriaModeloDataContext();

                c = new AuditoriaCapacitacionYBienestar
                {
                    p1 = p1,
                    p2 = p2,
                    p3 = p3,
                    p4 = p4,
                    p5 = p5,
                    p6 = p6,
                    p7 = p7,
                    p8 = p8,
                    comentario = DateTime.Now.ToShortDateString() + " - " + comentario,
                    idAuditor = auditorActivo.idAuditor,
                    idEmpresa = empresaActiva.idEmpresa
                };

                contexto.AuditoriaCapacitacionYBienestar.InsertOnSubmit(c);
                contexto.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
