using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class HospitalesController
    {
        public int save(int est, string codHos, string nomHos)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.HospitalesSS
                              where d.CodigoHospital == codHos
                              select d;
                    if (lst.Count() == 0)
                    {
                        HospitalesSS hospital = new HospitalesSS();
                        hospital.CodigoHospital = codHos;
                        hospital.NombreHospital = nomHos;
                        hospital.Estado = est;
                        db.HospitalesSS.Add(hospital);
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

        public bool edit(int est, string codHos, string nomHos, HospitalesSS h)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    h.CodigoHospital = codHos;
                    h.NombreHospital = nomHos;
                    h.Estado = est;

                    db.Entry(h).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public HospitalesSS getHospital(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    HospitalesSS h = db.HospitalesSS.Find(id);
                    return h;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<HospitalesSS> getAllHos()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.HospitalesSS
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<HospitalesSS> customHos = new List<HospitalesSS>();
                    foreach (var hos in lst)
                    {
                        HospitalesSS hospital = new HospitalesSS();
                        hospital.CodigoHospital = hos.CodigoHospital;
                        hospital.NombreHospital = hos.NombreHospital;
                        hospital.Estado = hos.Estado;
                        customHos.Add(hospital);
                    }
                    return customHos;
                }
                else
                {
                    List<HospitalesSS> newHos = new List<HospitalesSS>();
                    return newHos;
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
                    HospitalesSS hos = db.HospitalesSS.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.HospitalesSS.Remove(hos);
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
