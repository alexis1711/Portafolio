using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class EstadoController
    {
        public int save(string descripcion)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.Estado
                              where d.Descripcion == descripcion
                              select d;

                    if (lst.Count() == 0)
                    {
                        Estado est = new Estado();
                        est.Descripcion = descripcion;
                        db.Estado.Add(est);
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

        public List<Estado> getAllEst()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Estado
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Estado> customL = new List<Estado>();
                    foreach (var est in lst)
                    {
                        Estado estado = new Estado();
                        estado.Id = est.Id;
                        estado.Descripcion = (est.Descripcion != "" ? est.Descripcion : "No hay descripción");
                        customL.Add(estado);
                    }
                    return customL;
                }
                else
                {
                    List<Estado> newBR = new List<Estado>();
                    return newBR;
                }
            }
        }

        public bool edit(string desc, Estado estado)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    estado.Descripcion = desc;
                    db.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool delete(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    //se obtiene el objeto a borrar
                    Estado est = db.Estado.Find(id);
                    //se borra el objeto
                    db.Estado.Remove(est);
                    //se guardan cambios
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
        public Estado getEst(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Estado est = db.Estado.Find(id);
                    return est;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
