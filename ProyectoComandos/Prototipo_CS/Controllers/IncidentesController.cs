using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class IncidentesController
    {
        public int save(int tipoInc, string codInc, string desc)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.Incidentes
                              where d.CodigoIncidente == codInc
                              select d;
                    if (lst.Count() == 0)
                    {
                        Incidentes incidente = new Incidentes();
                        incidente.CodigoIncidente = codInc;
                        incidente.Descripcion = desc;
                        incidente.TipoIncidente= tipoInc;
                        db.Incidentes.Add(incidente);
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

        public bool edit(int tipoInc, string codInc, string desc, Incidentes i)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    i.CodigoIncidente = codInc;
                    i.Descripcion = desc;
                    i.TipoIncidente = tipoInc;

                    db.Entry(i).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public Incidentes getIncidente(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Incidentes i = db.Incidentes.Find(id);
                    return i;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<Incidentes> getAllInc()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Incidentes
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Incidentes> customInc = new List<Incidentes>();
                    foreach (var inc in lst)
                    {
                        Incidentes incidente = new Incidentes();
                        incidente.CodigoIncidente = inc.CodigoIncidente;
                        incidente.TipoIncidente = inc.TipoIncidente;
                        incidente.Descripcion = inc.Descripcion;
                        customInc.Add(incidente);
                    }
                    return customInc;
                }
                else
                {
                    List<Incidentes> newInc = new List<Incidentes>();
                    return newInc;
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
                    Incidentes inc = db.Incidentes.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.Incidentes.Remove(inc);
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
