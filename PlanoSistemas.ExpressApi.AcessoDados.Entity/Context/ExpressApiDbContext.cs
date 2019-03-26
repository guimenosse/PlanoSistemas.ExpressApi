using PlanoSistemas.ExpressApi.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoSistemas.ExpressApi.AcessoDados.Entity.Context
{
    public class ExpressApiDbContext : DbContext 
    {
        public DbSet<CL_Emitente> Emitentes { get; set; }

        public ExpressApiDbContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
