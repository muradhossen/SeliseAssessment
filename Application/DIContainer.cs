﻿using Application.ServiceInterfaces;
using Application.Services; 
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DIContainer
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ITodoService, TodoService>();

            return services;
        }

    }
}
