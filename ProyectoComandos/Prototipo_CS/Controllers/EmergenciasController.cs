using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class EmergenciasController
    {
        public int save(int codEm, string codInc, int tipoLl, string obsv, string lugar)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.Emergencias
                              where d.CodEmergencia == codEm
                              select d;
                    if (lst.Count() == 0)
                    {
                        Emergencias emergencia = new Emergencias();
                        emergencia.CodEmergencia = codEm;
                        emergencia.CodIncidente = codInc;
                        emergencia.TipoLlamada = tipoLl;
                        emergencia.Observaciones = obsv;
                        emergencia.LugarIncidente = lugar;
                        db.Emergencias.Add(emergencia);
                        db.SaveChanges();
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }

                }
                catch
                { return 0; }
            }
        }

        public bool edit(int codEm, string codInc, int tipoLl, string obsv, string lugar, Emergencias e)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    e.CodEmergencia = codEm;
                    e.CodIncidente = codInc;
                    e.TipoLlamada = tipoLl;
                    e.Observaciones = obsv;
                    e.LugarIncidente = lugar;

                    db.Entry(e).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public Emergencias getEmergencia(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Emergencias e = db.Emergencias.Find(id);
                    return e;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<Emergencias> getAllEmergencias()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Emergencias
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Emergencias> customEm = new List<Emergencias>();
                    foreach (var em in lst)
                    {
                        Emergencias emergencia = new Emergencias();
                        emergencia.CodEmergencia = em.CodEmergencia;
                        emergencia.CodIncidente = em.CodIncidente;
                        emergencia.TipoLlamada = em.TipoLlamada;
                        emergencia.Observaciones = em.Observaciones;
                        emergencia.LugarIncidente = em.LugarIncidente;
                        customEm.Add(emergencia);
                    }
                    return customEm;
                }
                else
                {
                    List<Emergencias> newEm = new List<Emergencias>();
                    return newEm;
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
                    Emergencias em = db.Emergencias.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.Emergencias.Remove(em);
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
