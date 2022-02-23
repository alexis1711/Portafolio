using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class UnidadesController
    {
        public int save(string codUni, string placas, string desc, int est)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.Unidades
                              where d.CodigoUnidad == codUni
                              select d;
                    if (lst.Count() == 0)
                    {
                        Unidades uni = new Unidades();
                        uni.CodigoUnidad = codUni;
                        uni.Placas = placas;
                        uni.Descripcion = desc;
                        uni.Estado = est;
                        db.Unidades.Add(uni);
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

        public bool edit(string codUni, string placas, string desc, int est, Unidades u)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    u.CodigoUnidad = codUni;
                    u.Placas = placas;
                    u.Descripcion = desc;
                    u.Estado = est;

                    db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public Unidades getUnidad(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Unidades u = db.Unidades.Find(id);
                    return u;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<Unidades> getAllUnidades()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Unidades
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Unidades> customUni = new List<Unidades>();
                    foreach (var uni in lst)
                    {
                        Unidades unidad = new Unidades();
                        unidad.CodigoUnidad = uni.CodigoUnidad;
                        unidad.Placas = uni.Placas;
                        unidad.Descripcion = uni.Descripcion;
                        unidad.Estado = uni.Estado;
                        customUni.Add(unidad);
                    }
                    return customUni;
                }
                else
                {
                    List<Unidades> newUni = new List<Unidades>();
                    return newUni;
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
                    Unidades uni = db.Unidades.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.Unidades.Remove(uni);
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
