using Akka.Actor;

namespace manager
{
    internal class ServiceRootActor : ReceiveActor
    {
        public static Props Props() => 
            Akka.Actor.Props.Create(() => new ServiceRootActor());

        public ServiceRootActor()
        {
            
        }
    }
}