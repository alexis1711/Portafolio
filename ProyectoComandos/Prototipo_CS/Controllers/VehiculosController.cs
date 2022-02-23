using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class VehiculosController
    {
        public int save(string numPla, string desc)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {

                    var lst = from d in db.Vehiculos
                              where d.NumeroPlaca == numPla
                              select d;
                    if (lst.Count() == 0)
                    {
                        Vehiculos veh = new Vehiculos();
                        veh.NumeroPlaca = numPla;
                        veh.Descripcion = desc;
                        db.Vehiculos.Add(veh);
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

        public bool edit(string numPla, string desc, Vehiculos v)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    v.NumeroPlaca = numPla;
                    v.Descripcion = desc;

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

        public Vehiculos getVehiculo(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Vehiculos v = db.Vehiculos.Find(id);
                    return v;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<Vehiculos> getAllVehiculos()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Vehiculos
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Vehiculos> customVehiculos = new List<Vehiculos>();
                    foreach (var veh in lst)
                    {
                        Vehiculos vehiculo = new Vehiculos();
                        vehiculo.NumeroPlaca = veh.NumeroPlaca;
                        vehiculo.Descripcion = veh.Descripcion;
                        customVehiculos.Add(vehiculo);
                    }
                    return customVehiculos;
                }
                else
                {
                    List<Vehiculos> newUniC = new List<Vehiculos>();
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
                    Vehiculos veh = db.Vehiculos.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.Vehiculos.Remove(veh);
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
