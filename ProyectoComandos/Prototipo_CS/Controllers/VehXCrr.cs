using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class VehXCrr
    {
        public int save(string numPla, int codCorr)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    VehiculosXCorrelativo vehC = new VehiculosXCorrelativo();
                    vehC.NumPlaca = numPla;
                    vehC.CodCorrelativo = codCorr;
                    db.VehiculosXCorrelativo.Add(vehC);
                    db.SaveChanges();
                    return 1;
                }
                catch
                { return 0; }
            }
        }

        public bool edit(string numPla, int codCorr, VehiculosXCorrelativo v)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    v.NumPlaca = numPla;
                    v.CodCorrelativo = codCorr;

                    db.Entry(v).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public VehiculosXCorrelativo getVehXCrr(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    VehiculosXCorrelativo v = db.VehiculosXCorrelativo.Find(id);
                    return v;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<VehiculosXCorrelativo> getAllVehXCrr()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.VehiculosXCorrelativo
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<VehiculosXCorrelativo> customVehC = new List<VehiculosXCorrelativo>();
                    foreach (var vehC in lst)
                    {
                        VehiculosXCorrelativo vehXc = new VehiculosXCorrelativo();
                        vehXc.CodCorrelativo = vehC.CodCorrelativo;
                        vehXc.NumPlaca = vehC.NumPlaca;
                        customVehC.Add(vehXc);
                    }
                    return customVehC;
                }
                else
                {
                    List<VehiculosXCorrelativo> newVehC = new List<VehiculosXCorrelativo>();
                    return newVehC;
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
                    VehiculosXCorrelativo vehC = db.VehiculosXCorrelativo.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.VehiculosXCorrelativo.Remove(vehC);
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
