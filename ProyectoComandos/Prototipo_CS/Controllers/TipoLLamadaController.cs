using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class TipoLLamadaController
    {
        public int save(string tipo)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.TipoLlamada
                              where d.TipoLlamada1 == tipo
                              select d;
                    if (lst.Count() == 0)
                    {
                        TipoLlamada tipoLl = new TipoLlamada();
                        tipoLl.TipoLlamada1 = tipo;
                        db.TipoLlamada.Add(tipoLl);
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

        public bool edit(string tipo, TipoLlamada t)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    t.TipoLlamada1 = tipo;

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

        public TipoLlamada getTipoLlamada(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    TipoLlamada t = db.TipoLlamada.Find(id);
                    return t;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<TipoLlamada> getAllTipoLlamada()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.TipoLlamada
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<TipoLlamada> customTip = new List<TipoLlamada>();
                    foreach (var tip in lst)
                    {
                        TipoLlamada tipo = new TipoLlamada();
                        tipo.Id = tip.Id;
                        tipo.TipoLlamada1 = tip.TipoLlamada1;
                        customTip.Add(tipo);
                    }
                    return customTip;
                }
                else
                {
                    List<TipoLlamada> newTip = new List<TipoLlamada>();
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
                    TipoLlamada tip = db.TipoLlamada.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.TipoLlamada.Remove(tip);
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
