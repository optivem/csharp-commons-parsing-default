﻿using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optivem.DependencyInjection.Core.Application;
using Optivem.DependencyInjection.Core.Domain;
using Optivem.DependencyInjection.Infrastructure.AutoMapper;
using Optivem.DependencyInjection.Infrastructure.EntityFrameworkCore;
using Optivem.DependencyInjection.Infrastructure.FluentValidation;
using Optivem.DependencyInjection.Infrastructure.MediatR;
using Optivem.DependencyInjection.Infrastructure.NewtonsoftJson;
using Optivem.Template.Infrastructure.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace Optivem.Template.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        private const string DatabaseConnectionKey = "DefaultConnection";

        public static void AddModules(this IServiceCollection services, IConfiguration configuration)
        {
            var coreModules = new List<Type>
            {
                typeof(Core.Application.Module),
                typeof(Core.Domain.Module),
            };

            var infrastructureModules = new List<Type>
            {
                typeof(Infrastructure.AutoMapper.Module),
                typeof(Infrastructure.EntityFrameworkCore.Module),
                typeof(Infrastructure.FluentValidation.Module),
                typeof(Infrastructure.MediatR.Module),
            };

            var modules = new List<Type>();
            modules.AddRange(coreModules);
            modules.AddRange(infrastructureModules);

            var assemblies = modules.Select(e => e.Assembly).ToArray();

            // var assemblies = null;

            // Core
            services.AddApplicationCore(assemblies);
            services.AddDomainCore(assemblies);

            // Infrastructure
            var connection = configuration.GetConnectionString(DatabaseConnectionKey);
            services.AddEntityFrameworkCoreInfrastructure<DatabaseContext>(options => options.UseSqlServer(connection), assemblies);
            services.AddAutoMapperInfrastructure(assemblies);
            services.AddFluentValidationInfrastructure(assemblies);
            services.AddMediatRInfrastructure(assemblies);
            services.AddNewtonsoftJsonInfrastructure(assemblies);
        }
    }
}