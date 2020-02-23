using System;
using Microsoft.Extensions.DependencyInjection;
using Shiny;
using Shiny.Prism;

namespace ModemConfigurator
{
    public class ModemStartup : PrismStartup
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            services.UseNotifications();
        }
    }
}
