using PlanoSistemas.Comum.Repositorios.Interfaces;
using PlanoSistemas.ExpressApi.Dominio;
using PlanoSistemas.ExpressApi.Repositorios.Entity;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlanoSistemas.ExpressApi.Api.Controllers
{
    public class EmitentesController : ApiController
    {
        private IRepositorioPlanoSistemas<CL_Emitente, int> _repositorioEmitentes
            = new RepositorioEmitentes(new AcessoDados.Entity.Context.ExpressApiDbContext());

        public IHttpActionResult Get()
        {
            return Ok(_repositorioEmitentes.Selecionar());
        }

        public IHttpActionResult Get(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }

            CL_Emitente emitente = _repositorioEmitentes.SelecionarPorId(id.Value);

            if (emitente == null)
            {
                return NotFound();
            }

            return Content(HttpStatusCode.Found, emitente);
        }

        public IHttpActionResult Post([FromBody]CL_Emitente emitente)
        {
            try
            {
                _repositorioEmitentes.Inserir(emitente);
                return Created($"{Request.RequestUri}/{emitente.Codigo}", emitente);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            
        }

        public IHttpActionResult Put(int? id, [FromBody]CL_Emitente emitente)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }
                emitente.Codigo = id.Value;
                _repositorioEmitentes.Atualizar(emitente);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Delete(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }
                CL_Emitente emitente = _repositorioEmitentes.SelecionarPorId(id.Value);
                if (emitente == null)
                {
                    return NotFound();
                }
                _repositorioEmitentes.ExcluirPorId(id.Value);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
