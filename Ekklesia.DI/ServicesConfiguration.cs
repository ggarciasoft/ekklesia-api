﻿using Ekklesia.Business.Services;
using Ekklesia.Infrastructure.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ekklesia.DI
{
    public static class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IService<>), typeof(CommonService<>));
        }
    }
}
