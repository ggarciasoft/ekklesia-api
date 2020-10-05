using System;
using System.Collections.Generic;
using System.Text;
using Ekklesia;
using AutoMapper;

namespace Ekklesia.Infrastructure
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            new MapperConfiguration(cfg => cfg.CreateMap<Models.Activity, DTO.Activity>());
        }
    }
}
