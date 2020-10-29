using Akka.Actor;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace manager
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

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var serviceRootActor = ActorSystem.ActorOf(Props.Create(() => new ServiceRootActor()), nameof(ServiceRootActor));

            await Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}