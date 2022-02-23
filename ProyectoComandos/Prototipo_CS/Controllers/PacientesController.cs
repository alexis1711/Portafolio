using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class PacientesController
    {
        public int save(string codPac, string priNom, string segNom, string priAp, string segAp, int gen, string dircc, int? edad)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.Pacientes
                              where d.CodigoPaciente == codPac
                              select d;
                    if (lst.Count() == 0)
                    {
                        Pacientes paciente = new Pacientes();
                        paciente.CodigoPaciente = codPac;
                        paciente.PrimerNombrePaciente = priNom;
                        paciente.SegundoNombrePaciente = segNom;
                        paciente.PrimerApellidoPaciente = priAp;
                        paciente.SegundoApellidoPaciente = segAp;
                        paciente.Genero = gen;
                        paciente.Direccion = dircc;
                        paciente.Edad = edad;
                        db.Pacientes.Add(paciente);
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

        public bool edit(string codPac, string priNom, string segNom, string priAp, string segAp, int gen, string dircc, int? edad, Pacientes p)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    p.CodigoPaciente = codPac;
                    p.PrimerNombrePaciente = priNom;
                    p.SegundoNombrePaciente = segNom;
                    p.PrimerApellidoPaciente = priAp;
                    p.SegundoApellidoPaciente = segAp;
                    p.Genero = gen;
                    p.Direccion = dircc;
                    p.Edad = edad;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public Pacientes getEmpleado(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Pacientes p = db.Pacientes.Find(id);
                    return p;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<Pacientes> getAllPacientes()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Pacientes
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Pacientes> customPac = new List<Pacientes>();
                    foreach (var p in lst)
                    {
                        Pacientes paciente = new Pacientes();
                        paciente.CodigoPaciente = p.CodigoPaciente;
                        paciente.PrimerNombrePaciente = p.PrimerNombrePaciente;
                        paciente.SegundoNombrePaciente = p.SegundoNombrePaciente;
                        paciente.PrimerApellidoPaciente = p.PrimerApellidoPaciente;
                        paciente.SegundoApellidoPaciente = p.SegundoApellidoPaciente;
                        paciente.Genero = p.Genero;
                        paciente.Direccion = p.Direccion;
                        paciente.Edad = p.Edad;
                        customPac.Add(paciente);
                    }
                    return customPac;
                }
                else
                {
                    List<Pacientes> newPac = new List<Pacientes>();
                    return newPac;
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
                    Pacientes p = db.Pacientes.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.Pacientes.Remove(p);
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
