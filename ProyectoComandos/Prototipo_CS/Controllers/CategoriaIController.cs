using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class CategoriaIController
    {
        public int save( string tipo)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.CategoriaIncidentes
                              where d.Tipo == tipo
                              select d;
                    if (lst.Count() == 0)
                    {
                        CategoriaIncidentes categoria = new CategoriaIncidentes();
                        categoria.Tipo = tipo;
                        db.CategoriaIncidentes.Add(categoria);
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

        public bool edit( string tipo, CategoriaIncidentes c)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    c.Tipo = tipo;

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
        public CategoriaIncidentes getCategoriaI(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    CategoriaIncidentes c = db.CategoriaIncidentes.Find(id);
                    return c;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<CategoriaIncidentes> getAllCatI()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.CategoriaIncidentes
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<CategoriaIncidentes> customCat = new List<CategoriaIncidentes>();
                    foreach (var cat in lst)
                    {
                        CategoriaIncidentes categoria = new CategoriaIncidentes();
                        categoria.Id = cat.Id;
                        categoria.Tipo = cat.Tipo;
                        customCat.Add(categoria);
                    }
                    return customCat;
                }
                else
                {
                    List<CategoriaIncidentes> newCat = new List<CategoriaIncidentes>();
                    return newCat;
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
                    CategoriaIncidentes cat = db.CategoriaIncidentes.Find(id);
                    //Se borra el objeto que se obtuvo de la tabla
                    db.CategoriaIncidentes.Remove(cat);
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
