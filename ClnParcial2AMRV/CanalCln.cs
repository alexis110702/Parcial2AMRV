using CadParcial2AMRV;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2AMRV
{
    public class CanalCln
    {
        public static List<Canal> listar()
        {
            using (var context = new Parcial2AMRVEntities())
            {
                return context.Canal
                    .Where(x => x.estado == 1)
                    .OrderBy(x => x.nombre)
                    .ToList();
            }
        }
    }
}
