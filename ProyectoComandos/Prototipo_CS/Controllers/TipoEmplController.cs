using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class TipoEmplController
    {
        public int save(string tipo)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.TipoEmpleado
                              where d.Tipo == tipo
                              select d;
                    if (lst.Count() == 0)
                    {
                        TipoEmpleado tipoE = new TipoEmpleado();
                        tipoE.Tipo = tipo;
                        db.TipoEmpleado.Add(tipoE);
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

        public bool edit(string tipo, TipoEmpleado t)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    t.Tipo = tipo;

                    db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public TipoEmpleado getTipoEmpl(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    TipoEmpleado t = db.TipoEmpleado.Find(id);
                    return t;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<TipoEmpleado> getAllTipoEmpl()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.TipoEmpleado
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<TipoEmpleado> customTip = new List<TipoEmpleado>();
                    foreach (var tip in lst)
                    {
                        TipoEmpleado tipo = new TipoEmpleado();
                        tipo.Id = tip.Id;
                        tipo.Tipo = tip.Tipo;
                        customTip.Add(tipo);
                    }
                    return customTip;
                }
                else
                {
                    List<TipoEmpleado> newTip = new List<TipoEmpleado>();
                    return newTip;
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
                    TipoEmpleado tip = db.TipoEmpleado.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.TipoEmpleado.Remove(tip);
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
