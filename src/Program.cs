using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace practice {
    class Program {
        static void Main (string[] args) {
            CreateHostBuilder (args)
                .ConfigureLogging (logging => {
                    logging.ClearProviders ();
                    logging.AddConsole ();
                })
                .Build ().Run ();
        }

        public static IHostBuilder CreateHostBuilder (string[] args) =>
            Host.CreateDefaultBuilder (args)
            .ConfigureServices ((hostContext, services) => {
                services.AddHostedService<App> ();
            });
    }
}