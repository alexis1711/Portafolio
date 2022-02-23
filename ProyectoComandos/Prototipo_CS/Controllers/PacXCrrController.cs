using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class PacXCrrController
    {
        public int save(int codCrr, string codPac, int? FC, int? FR, int? PA, double? T, double? SO, string codHos, string Tel,
            string nomAco, string par, string diag, TimeSpan? hoLl)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    PacientesXCorrelativo pacXc = new PacientesXCorrelativo();
                    pacXc.CodCorrelativo = codCrr;
                    pacXc.CodPaciente = codPac;
                    pacXc.FrecuenciaCardiaca = FC;
                    pacXc.FrecuenciaRespiratoria = FR;
                    pacXc.PresionArterial = PA;
                    pacXc.Temperatura = T;
                    pacXc.SaturacionOxigeno = SO;
                    pacXc.CodHospital = codHos;
                    pacXc.Telefono = Tel;
                    pacXc.NombreAcompañante = nomAco;
                    pacXc.Parentesco = par;
                    pacXc.Diagnostico = diag;
                    pacXc.HoraLlegada = hoLl;
                    db.PacientesXCorrelativo.Add(pacXc);
                    db.SaveChanges();
                    return 1;
                }
                catch
                { return 0; }
            }
        }

        public bool edit(int codCrr, string codPac,int? FC, int? FR, int? PA, double? T, double? SO,string codHos, string Tel,
            string nomAco, string par,string diag,TimeSpan? hoLl, PacientesXCorrelativo pacXc)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    pacXc.CodCorrelativo = codCrr;
                    pacXc.CodPaciente = codPac;
                    pacXc.FrecuenciaCardiaca = FC;
                    pacXc.FrecuenciaRespiratoria = FR;
                    pacXc.PresionArterial = PA;
                    pacXc.Temperatura = T;
                    pacXc.SaturacionOxigeno = SO;
                    pacXc.CodHospital = codHos;
                    pacXc.Telefono = Tel;
                    pacXc.NombreAcompañante = nomAco;
                    pacXc.Parentesco = par;
                    pacXc.Diagnostico = diag;
                    pacXc.HoraLlegada = hoLl;

                    db.Entry(pacXc).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public PacientesXCorrelativo getPacXc(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    PacientesXCorrelativo pacXc = db.PacientesXCorrelativo.Find(id);
                    return pacXc;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<PacientesXCorrelativo> getAllPacXCrr()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.PacientesXCorrelativo
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<PacientesXCorrelativo> custompacXc = new List<PacientesXCorrelativo>();
                    foreach (var pacXc in lst)
                    {
                        PacientesXCorrelativo pacXcrr = new PacientesXCorrelativo();
                        pacXcrr.CodCorrelativo = pacXc.CodCorrelativo;
                        pacXcrr.CodPaciente = pacXc.CodPaciente;
                        pacXcrr.FrecuenciaCardiaca = pacXc.FrecuenciaCardiaca;
                        pacXcrr.FrecuenciaRespiratoria = pacXc.FrecuenciaRespiratoria;
                        pacXcrr.PresionArterial = pacXc.PresionArterial;
                        pacXcrr.Temperatura = pacXc.Temperatura;
                        pacXcrr.SaturacionOxigeno = pacXc.SaturacionOxigeno;
                        pacXcrr.CodHospital = pacXc.CodHospital;
                        pacXcrr.Telefono = pacXc.Telefono;
                        pacXcrr.NombreAcompañante = pacXc.NombreAcompañante;
                        pacXcrr.Parentesco = pacXc.Parentesco;
                        pacXcrr.Diagnostico = pacXc.Diagnostico;
                        pacXcrr.HoraLlegada = pacXc.HoraLlegada;
                        custompacXc.Add(pacXcrr);
                    }
                    return custompacXc;
                }
                else
                {
                    List<PacientesXCorrelativo> newpacXc = new List<PacientesXCorrelativo>();
                    return newpacXc;
                }
            }
        }
        public bool delete(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    //Se obtiene el objeto a borrar
                    PacientesXCorrelativo pacXc = db.PacientesXCorrelativo.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.PacientesXCorrelativo.Remove(pacXc);
                    //Guardamos cambios
                    db.SaveChanges();
                    //Si todo bien regreso true
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
