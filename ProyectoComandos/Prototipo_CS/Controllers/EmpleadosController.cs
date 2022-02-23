using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class EmpleadosController
    {
        public int save(string codEm, string priNom, string segNom, string priAp, string segAp, int gen, DateTime fechaN, int tipoEm, int est)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.Empleados
                              where d.CodigoEmpleado == codEm
                              select d;
                    if (lst.Count() == 0)
                    {
                        Empleados empleado = new Empleados();
                        empleado.CodigoEmpleado = codEm;
                        empleado.PrimerNombreEmpleado = priNom;
                        empleado.SegundoNombreEmpleado = segNom;
                        empleado.PrimerApellidoEmpleado = priAp;
                        empleado.SegundoApellidoEmpleado = segAp;
                        empleado.Genero = gen;
                        empleado.FechaNacimiento = fechaN;
                        empleado.TipoEmpleado = tipoEm;
                        empleado.Estado = est;
                        db.Empleados.Add(empleado);
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

        public bool edit(string codEm, string priNom, string segNom, string priAp, string segAp, int gen, DateTime fechaN, int tipoEm, int est, Empleados e)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    e.CodigoEmpleado = codEm;
                    e.PrimerNombreEmpleado = priNom;
                    e.SegundoNombreEmpleado = segNom;
                    e.PrimerApellidoEmpleado = priAp;
                    e.SegundoApellidoEmpleado = segAp;
                    e.Genero = gen;
                    e.FechaNacimiento = fechaN;
                    e.TipoEmpleado = tipoEm;
                    e.Estado = est;

                    db.Entry(e).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public Empleados getEmpleado(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Empleados e = db.Empleados.Find(id);
                    return e;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<Empleados> getAllEmpleados()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Empleados
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Empleados> customEm = new List<Empleados>();
                    foreach (var em in lst)
                    {
                        Empleados empleado = new Empleados();
                        empleado.CodigoEmpleado = em.CodigoEmpleado;
                        empleado.PrimerNombreEmpleado = em.PrimerNombreEmpleado;
                        empleado.SegundoNombreEmpleado = em.SegundoNombreEmpleado;
                        empleado.PrimerApellidoEmpleado = em.PrimerApellidoEmpleado;
                        empleado.SegundoApellidoEmpleado = em.SegundoApellidoEmpleado;
                        empleado.Genero = em.Genero;
                        empleado.FechaNacimiento = em.FechaNacimiento;
                        empleado.TipoEmpleado = em.TipoEmpleado;
                        empleado.Estado = em.Estado;
                        customEm.Add(empleado);
                    }
                    return customEm;
                }
                else
                {
                    List<Empleados> newEm = new List<Empleados>();
                    return newEm;
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
                    Empleados em = db.Empleados.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.Empleados.Remove(em);
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
