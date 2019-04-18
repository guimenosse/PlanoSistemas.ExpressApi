using PlanoSistemas.ExpressApi.Dominio;
using System.Data.Entity;

namespace PlanoSistemas.ExpressApi.AcessoDados.Entity.Context
{
    public class ExpressApiDbContext : DbContext 
    {
        public DbSet<CL_Emitente> Emitentes { get; set; }

        public ExpressApiDbContext(string servidor): base(servidor)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        
    }
}
