using AutoMapper;
using PlanoSistemas.ExpressApi.Api.DTOs;
using PlanoSistemas.ExpressApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanoSistemas.ExpressApi.Api.AutoMapper
{
    public class AutoMapperManager
    {
        private static readonly Lazy<AutoMapperManager> _instance
            = new Lazy<AutoMapperManager>(() =>
            {
                return new AutoMapperManager();
            });

        public static AutoMapperManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private MapperConfiguration _config;
        public IMapper Mapper
        {
            get
            {
                return _config.CreateMapper();
            }
        }

        private AutoMapperManager()
        {
            _config = new MapperConfiguration((cfg) =>
            {
                cfg.CreateMap<CL_Emitente, CL_EmitenteDTO>();
                cfg.CreateMap<CL_EmitenteDTO, CL_Emitente>();
            });
        }
    }
}