namespace Ticketmaster.Discovery.Tests.V2
{
    using Core;
    using NSubstitute;
    using Ploeh.AutoFixture;
    using RestSharp;

    public abstract class MethodTest
    {
        protected readonly IRestClient Client;
        protected readonly IClientConfig Config;
        protected readonly Fixture Fixture;

        protected MethodTest()
        {
            Fixture = new Fixture();
            Config = Substitute.For<IClientConfig>();
            Config.ConsumerKey.Returns("K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX-1");
            Config.ApiRootUrl.Returns("https://app.ticketmaster.com/discovery/");
            Client = Substitute.For<IRestClient>();
        }
    }
}