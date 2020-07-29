using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace practice {
    public class App : IHostedService, IDisposable {
        private readonly ILogger<App> _logger;

        public App (ILogger<App> logger) {
            _logger = logger;
        }

        public Task StartAsync (CancellationToken stoppingToken) {
            _logger.LogInformation ("App is running.");
            return Task.CompletedTask;
        }

        public Task StopAsync (CancellationToken stoppingToken) {
            _logger.LogInformation ("App is stopping.");
            return Task.CompletedTask;
        }

        public void Dispose () {
            Dispose ();
        }
    }
}