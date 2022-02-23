using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class UniXCrr
    {
        public int save(string codUni, int codCorr)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {

                     UnidadesXCorrelativo uniC = new UnidadesXCorrelativo();
                     uniC.CodUnidad = codUni;
                     uniC.CodCorrelativo = codCorr;
                     db.UnidadesXCorrelativo.Add(uniC);
                     db.SaveChanges();
                     return 1;


                }
                catch
                { return 0; }
            }
        }

        public bool edit(string codUni, int codCorr, UnidadesXCorrelativo u)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    u.CodUnidad = codUni;
                    u.CodCorrelativo = codCorr;

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

        public UnidadesXCorrelativo getUniXCrr(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    UnidadesXCorrelativo u = db.UnidadesXCorrelativo.Find(id);
                    return u;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<UnidadesXCorrelativo> getAllUniXCrr()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.UnidadesXCorrelativo
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<UnidadesXCorrelativo> customUniC = new List<UnidadesXCorrelativo>();
                    foreach (var uniC in lst)
                    {
                        UnidadesXCorrelativo uniXc = new UnidadesXCorrelativo();
                        uniXc.CodCorrelativo = uniC.CodCorrelativo;
                        uniXc.CodUnidad = uniC.CodUnidad;
                        customUniC.Add(uniXc);
                    }
                    return customUniC;
                }
                else
                {
                    List<UnidadesXCorrelativo> newUniC = new List<UnidadesXCorrelativo>();
                    return newUniC;
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
                    UnidadesXCorrelativo uniC = db.UnidadesXCorrelativo.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.UnidadesXCorrelativo.Remove(uniC);
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
