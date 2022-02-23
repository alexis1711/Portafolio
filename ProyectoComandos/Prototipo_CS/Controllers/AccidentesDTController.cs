using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class AccidentesDTController
    {
        public int save(int codAc, string lugar, string obsv)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.AccidentesDeTransito
                              where d.CodigoAccidente == codAc
                              select d;
                    if (lst.Count() == 0)
                    {
                        AccidentesDeTransito accidente = new AccidentesDeTransito();
                        accidente.CodigoAccidente = codAc;
                        accidente.Lugar = lugar;
                        accidente.Observaciones = obsv;
                        db.AccidentesDeTransito.Add(accidente);
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

        public bool edit (int codAc, string lugar, string obsv, AccidentesDeTransito a)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    a.CodigoAccidente = codAc;
                    a.Lugar = lugar;
                    a.Observaciones = obsv;

                    db.Entry(a).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public AccidentesDeTransito getAccidenteDT(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    AccidentesDeTransito a = db.AccidentesDeTransito.Find(id);
                    return a;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<AccidentesDeTransito> getAllAccDT()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.AccidentesDeTransito
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<AccidentesDeTransito> customAcc = new List<AccidentesDeTransito>();
                    foreach (var acc in lst)
                    {
                        AccidentesDeTransito accidente = new AccidentesDeTransito();
                        accidente.CodigoAccidente = acc.CodigoAccidente;
                        accidente.Lugar = acc.Lugar;
                        accidente.Observaciones = acc.Observaciones;
                        customAcc.Add(accidente);
                    }
                    return customAcc;
                }
                else
                {
                    List<AccidentesDeTransito> newAcc = new List<AccidentesDeTransito>();
                    return newAcc;
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
                    AccidentesDeTransito acc = db.AccidentesDeTransito.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.AccidentesDeTransito.Remove(acc);
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
