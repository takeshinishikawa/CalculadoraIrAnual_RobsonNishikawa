using System;
using CalculadoraIrAnual.Presentation;
using CalculadoraIrAnual.ProgramFlows;
using CalculadoraIrAnual.ProgramFlows.Interfaces;
using CalculadorIrAnual.Services;
using CalculadorIrAnual.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CalculadoraIrAnual
{
    public class Program
    {
        public static void Main()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();
            var mainFlow = serviceProvider.GetService<IMainFlow>();
            mainFlow.BeginApp();
        }
        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IMainFlow, MainFlow>()
                .AddScoped<ITaxCalculator, TaxCalculator>();
        }

    }
}