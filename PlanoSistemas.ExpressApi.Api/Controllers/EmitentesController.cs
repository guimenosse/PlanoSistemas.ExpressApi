using PlanoSistemas.Comum.Repositorios.Interfaces;
using PlanoSistemas.ExpressApi.Api.AutoMapper;
using PlanoSistemas.ExpressApi.Api.DTOs;
using PlanoSistemas.ExpressApi.Api.Filters;
using PlanoSistemas.ExpressApi.Dominio;
using PlanoSistemas.ExpressApi.Repositorios.Entity;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace PlanoSistemas.ExpressApi.Api.Controllers
{
    public class EmitentesController : ApiController
    {
        //string de teste
        static string stringConexao = "Server=Desenv-Mac;DataBase=ExpressAPI_3;User Id=sa;Password=Pl@no_$i$tem@$";
            
        private IRepositorioPlanoSistemas<CL_Emitente, int> _repositorioEmitentes
            = new RepositorioEmitentes(new AcessoDados.Entity.Context.ExpressApiDbContext(stringConexao));

        public IHttpActionResult Get()
        {
            List<CL_Emitente> emitentes = _repositorioEmitentes.Selecionar();
            List<CL_EmitenteDTO> dtos
                = AutoMapperManager.Instance.Mapper.Map<List<CL_Emitente>, List<CL_EmitenteDTO>>(emitentes);
            return Ok(dtos);
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
            CL_EmitenteDTO dto = AutoMapperManager.Instance.Mapper.Map<CL_Emitente, CL_EmitenteDTO>(emitente);

            return Content(HttpStatusCode.Found, dto);
        }

        [ApplyModelValidation]
        public IHttpActionResult Post([FromBody]CL_EmitenteDTO dto)
        {
           
            try
            {
                CL_Emitente emitente = AutoMapperManager.Instance.Mapper.Map<CL_EmitenteDTO, CL_Emitente>(dto);
                _repositorioEmitentes.Inserir(emitente);
                return Created($"{Request.RequestUri}/{emitente.Codigo}", emitente);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }   
        }

        [ApplyModelValidation]
        public IHttpActionResult Put(int? id, [FromBody]CL_EmitenteDTO dto)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }

                CL_Emitente emitente = AutoMapperManager.Instance.Mapper.Map<CL_EmitenteDTO, CL_Emitente>(dto);
                _repositorioEmitentes.Inserir(emitente);
                
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
