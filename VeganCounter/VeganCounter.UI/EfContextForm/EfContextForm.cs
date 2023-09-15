﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VeganCounter.BLL.Concrete;



namespace VeganCounter.UI.EfContextForm
{
    public static class EfContextForm
    {
        private static IServiceProvider _serviceProvider;

        private static IHostBuilder CreateHostBuilder<T>() where T : class
        {
            var result = Host.CreateDefaultBuilder()
                             .ConfigureServices(services =>
                             {
                                 services.AddScopedBll()
                                         .AddTransient<T>();
                             });

            return result;
        }

        public static Form ConfigureService<T>() where T : Form
        {
            var host = CreateHostBuilder<T>().Build();
            _serviceProvider = host.Services;
            return _serviceProvider.GetRequiredService<T>();

        }
    }
}
