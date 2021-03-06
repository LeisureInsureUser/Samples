namespace SenderEndPoint
{
    using Conventions;
    using NServiceBus;
    using NServiceBus.Persistence;

    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, INeedInitialization
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<RavenDBPersistence>();
            configuration.ApplyCustomMessageConventions();
        }
    }
}