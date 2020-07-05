using DatingApp.Application.Interfaces;
using DatingApp.Application.Services;
using DatingApp.Domain.CommandHandlers;
using DatingApp.Domain.Commands;
using DatingApp.Domain.Core.Bus;
using DatingApp.Domain.Interfaces;
using DatingApp.Infra.Bus.InMemoryBus;
using DatingApp.Infra.Data.Context;
using DatingApp.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Infra.IoC.DependencyContainer
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateSampleCommand, bool>, SampleCommandHandler>();

            //Application Layer
            services.AddScoped<ISampleService, SampleService>();

            //Infra.Data Layer
            services.AddScoped<ISampleRepository, SampleRepository>();
            //services.AddScoped<SampleDBContext>();
        }
    }
}
