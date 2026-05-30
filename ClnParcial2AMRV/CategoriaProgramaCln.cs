using CadParcial2AMRV;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2AMRV
{
    public class CategoriaProgramaCln
    {
        public static List<CategoriaPrograma> listar()
        {
            using (var context = new Parcial2AMRVEntities())
            {
                return context.CategoriaPrograma
                    .Where(x => x.estado == 1)
                    .OrderBy(x => x.nombre)
                    .ToList();
            }
        }
    }
}