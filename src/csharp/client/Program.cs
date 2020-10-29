using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton(sp => Akka.Actor.ActorSystem.Create("mls.inference.manager"));
                    services.AddHostedService<AkkaHostedService>();
                })
        }
    }
}
