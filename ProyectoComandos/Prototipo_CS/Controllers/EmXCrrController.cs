using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class EmXCrrController
    {
        public int save( int codCrr, string codEm)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                        EmpleadosXCorrelativo emXc = new EmpleadosXCorrelativo();
                        emXc.CodCorrelativo = codCrr;
                        emXc.CodEmpleado = codEm;
                        db.EmpleadosXCorrelativo.Add(emXc);
                        db.SaveChanges();
                        return 1;
                }
                catch
                { return 0; }
            }
        }

        public bool edit(int id, int codCrr,string codEm, EmpleadosXCorrelativo emXc)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    emXc.Id = id;
                    emXc.CodCorrelativo = codCrr;
                    emXc.CodEmpleado = codEm;

                    db.Entry(emXc).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public EmpleadosXCorrelativo getEmXc(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    EmpleadosXCorrelativo emXc = db.EmpleadosXCorrelativo.Find(id);
                    return emXc;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<EmpleadosXCorrelativo> getAllEmXCrr()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.EmpleadosXCorrelativo
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<EmpleadosXCorrelativo> customemXc = new List<EmpleadosXCorrelativo>();
                    foreach (var emXc in lst)
                    {
                        EmpleadosXCorrelativo empXcrr = new EmpleadosXCorrelativo();
                        empXcrr.Id = emXc.Id;
                        empXcrr.CodCorrelativo = emXc.CodCorrelativo;
                        empXcrr.CodEmpleado = emXc.CodEmpleado;
                        customemXc.Add(empXcrr);
                    }
                    return customemXc;
                }
                else
                {
                    List<EmpleadosXCorrelativo> newemXc = new List<EmpleadosXCorrelativo>();
                    return newemXc;
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
                    EmpleadosXCorrelativo emXc = db.EmpleadosXCorrelativo.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.EmpleadosXCorrelativo.Remove(emXc);
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
