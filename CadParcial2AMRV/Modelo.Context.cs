
namespace CadParcial2AMRV
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    public partial class Parcial2AMRVEntities : DbContext
    {
        public Parcial2AMRVEntities()
            : base("name=Parcial2AMRVEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Canal>   Canal   { get; set; }
        public virtual DbSet<Programa> Programa { get; set; }

        public virtual ObjectResult<paProgramaListar_Result> paProgramaListar(string parametro)
        {
            var parametroParameter = parametro != null
                ? new ObjectParameter("parametro", parametro)
                : new ObjectParameter("parametro", typeof(string));

            return ((IObjectContextAdapter)this)
                .ObjectContext
                .ExecuteFunction<paProgramaListar_Result>("paProgramaListar", parametroParameter);
        }
    }
}
