using BudgetTool.Application.Interfaces;
using BudgetTool.Application.Services;
using BudgetTool.Domain.Interfaces;
using BudgetTool.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTool.Infra.IoC
{
    public class IoCContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application
            services.AddScoped<IBudgetService, BudgetService>();

            //Domain interfaces / repos
            services.AddScoped<IBudgetRepository, BudgetRepository>();
        }
    }
}
