using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class CorrelativoController
    {
        public int save( int tipo, DateTime fecha)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    
                        Correlativo correlativo1 = new Correlativo();
                        correlativo1.Tipo = tipo;
                        correlativo1.Fecha = fecha;
                        db.Correlativo.Add(correlativo1);
                        db.SaveChanges();
                        return 1;

                }
                catch
                { return 0; }
            }
        }

        public bool edit(int correlativo, int tipo, DateTime fecha, Correlativo c)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    c.Correlativo1 = correlativo;
                    c.Tipo = tipo;
                    c.Fecha = fecha;

                    db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public Correlativo getCorrelativo(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Correlativo c = db.Correlativo.Find(id);
                    return c;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<Correlativo> getAllCrr()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Correlativo
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Correlativo> customCrr = new List<Correlativo>();
                    foreach (var crr in lst)
                    {
                        Correlativo correlativo = new Correlativo();
                        correlativo.Correlativo1 = crr.Correlativo1;
                        correlativo.Tipo = crr.Tipo;
                        correlativo.Fecha = crr.Fecha;
                        customCrr.Add(correlativo);
                    }
                    return customCrr;
                }
                else
                {
                    List<Correlativo> newCrr = new List<Correlativo>();
                    return newCrr;
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
                    Correlativo crr = db.Correlativo.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.Correlativo.Remove(crr);
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
