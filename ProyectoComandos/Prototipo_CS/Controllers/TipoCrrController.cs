using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class TipoCrrController
    {
        public int save(string tipo)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.TipoCorrelativo
                              where d.Tipo == tipo
                              select d;
                    if (lst.Count() == 0)
                    {
                        TipoCorrelativo tipoC = new TipoCorrelativo();
                        tipoC.Tipo = tipo;
                        db.TipoCorrelativo.Add(tipoC);
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

        public bool edit(string tipo, TipoCorrelativo t)
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

        public TipoCorrelativo getTipoCrr(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    TipoCorrelativo t = db.TipoCorrelativo.Find(id);
                    return t;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<TipoCorrelativo> getAllTipoCrr()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.TipoCorrelativo
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<TipoCorrelativo> customTip = new List<TipoCorrelativo>();
                    foreach (var tip in lst)
                    {
                        TipoCorrelativo tipo = new TipoCorrelativo();
                        tipo.Id = tip.Id;
                        tipo.Tipo = tip.Tipo;
                        customTip.Add(tipo);
                    }
                    return customTip;
                }
                else
                {
                    List<TipoCorrelativo> newTip = new List<TipoCorrelativo>();
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
                    TipoCorrelativo tip = db.TipoCorrelativo.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.TipoCorrelativo.Remove(tip);
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
