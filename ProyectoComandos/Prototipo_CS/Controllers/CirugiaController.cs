using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class CirugiaController
    {
        public int save(int codCir, string proced)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.Cirugias
                              where d.CodigoCirugia == codCir
                              select d;
                    if (lst.Count() == 0)
                    {
                        Cirugias cirugia = new Cirugias();
                        cirugia.CodigoCirugia = codCir;
                        cirugia.Procedimiento = proced;
                        db.Cirugias.Add(cirugia);
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

        public bool edit(int codCir, string proced, Cirugias c)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    c.CodigoCirugia = codCir;
                    c.Procedimiento = proced;

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
        public Cirugias getCirugia(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Cirugias c = db.Cirugias.Find(id);
                    return c;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<Cirugias> getAllCirugias()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Cirugias
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Cirugias> customCir = new List<Cirugias>();
                    foreach (var cir in lst)
                    {
                        Cirugias cirugia = new Cirugias();
                        cirugia.CodigoCirugia = cir.CodigoCirugia;
                        cirugia.Procedimiento = cir.Procedimiento;
                        customCir.Add(cirugia);
                    }
                    return customCir;
                }
                else
                {
                    List<Cirugias> newCir = new List<Cirugias>();
                    return newCir;
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
                    Cirugias cir = db.Cirugias.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.Cirugias.Remove(cir);
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
