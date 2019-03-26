using PlanoSistemas.Comum.Repositorios.Entity;
using PlanoSistemas.ExpressApi.AcessoDados.Entity.Context;
using PlanoSistemas.ExpressApi.Dominio;

namespace PlanoSistemas.ExpressApi.Repositorios.Entity
{
    public class RepositorioEmitentes : RepositorioPlanoSistemas<CL_Emitente, int>
    {
        public RepositorioEmitentes(ExpressApiDbContext context)
            : base(context)
        {

        }
    }
}
