using Akka.Actor;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace client
{
    internal class AkkaHostedService : IHostedService
    {
        public AkkaHostedService(ActorSystem actorSystem, ILogger<AkkaHostedService> logger)
        {
            ActorSystem = actorSystem;
            Logger = logger;
        }

        public ActorSystem ActorSystem { get; }
        public ILogger<AkkaHostedService> Logger { get; }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            ActorSystem.ActorOf

            throw new System.NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}