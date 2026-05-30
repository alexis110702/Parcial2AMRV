using CadParcial2AMRV;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2AMRV
{
    public class ProgramaCln
    {
        public static int crear(Programa programa)
        {
            using (var context = new Parcial2AMRVEntities())
            {
                context.Programa.Add(programa);
                context.SaveChanges();
                return programa.id;
            }
        }

        public static int modificar(Programa programa)
        {
            using (var context = new Parcial2AMRVEntities())
            {
                var existente = context.Programa.Find(programa.id);
                if (existente != null)
                {
                    existente.idCanal = programa.idCanal;
                    existente.idCategoriaPrograma = programa.idCategoriaPrograma;
                    existente.titulo = programa.titulo;
                    existente.descripcion = programa.descripcion;
                    existente.duracion = programa.duracion;
                    existente.productor = programa.productor;
                    existente.fechaEstreno = programa.fechaEstreno;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static int eliminar(int id)
        {
            using (var context = new Parcial2AMRVEntities())
            {
                var existente = context.Programa.Find(id);
                if (existente != null)
                {
                    existente.estado = -1;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static Programa obtenerUno(int id)
        {
            using (var context = new Parcial2AMRVEntities())
            {
                return context.Programa.Find(id);
            }
        }

        public static List<paProgramaListar_Result> listarPa(string parametro)
        {
            using (var context = new Parcial2AMRVEntities())
            {
                return context.paProgramaListar(parametro.Trim()).ToList();
            }
        }
    }
}