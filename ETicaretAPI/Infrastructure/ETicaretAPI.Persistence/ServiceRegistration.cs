﻿using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options =>options.UseNpgsql("User ID =postgres; Password =admin; Host = localhost; Port = 5432; Database = ETicaretAPIDb; "));
            
        }
    }
}

