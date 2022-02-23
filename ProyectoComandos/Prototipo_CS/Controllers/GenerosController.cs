using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_CS.EntityFramework;

namespace Prototipo_CS.Controllers
{
    class GenerosController
    {
        public int save(string genero)
        {
            //Abro conexion solamente cuando ejecute la accion
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    var lst = from d in db.Generos
                              where d.Genero == genero
                              select d;

                    if (lst.Count() == 0)
                    {
                        Generos gen = new Generos();
                        gen.Genero = genero;
                        db.Generos.Add(gen);
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

        public List<Generos> getAllGen()
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                //Obtengo todos los registros de mi tabla en la variable lst
                var lst = from d in db.Generos
                          select d;
                //Luego colocamos los registros que generamos de la base en el DataGridView y lo pasamos a lista para que
                //sea compatible con el DGV
                if (lst.Count() > 0)
                {
                    List<Generos> customG = new List<Generos>();
                    foreach (var gen in lst)
                    {
                        Generos genero = new Generos();
                        genero.Id = gen.Id;
                        genero.Genero = gen.Genero;
                        customG.Add(genero);
                    }
                    return customG;
                }
                else
                {
                    List<Generos> newG = new List<Generos>();
                    return newG;
                }
            }
        }

        public bool edit(string gen, Generos genero)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    genero.Genero = gen;
                    db.Entry(genero).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool delete(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    //se obtiene el objeto a borrar
                    Generos gen = db.Generos.Find(id);
                    //se borra el objeto
                    db.Generos.Remove(gen);
                    //se guardan cambios
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
        public Generos getGenero(int? id)
        {
            using (ComandosSalvamentoEntities db = new ComandosSalvamentoEntities())
            {
                try
                {
                    Generos gen = db.Generos.Find(id);
                    return gen;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
