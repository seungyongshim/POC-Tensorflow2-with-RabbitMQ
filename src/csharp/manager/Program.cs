using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace manager
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton(sp => Akka.Actor.ActorSystem.Create("mls.inference.manager"));
                    services.AddHostedService<AkkaHostedService>();
                })
                .Build()
                .RunAsync();
        }
    }
}
