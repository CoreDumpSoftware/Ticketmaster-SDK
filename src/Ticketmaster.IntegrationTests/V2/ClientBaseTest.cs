namespace Ticketmaster.IntegrationTests.V2
{
    using AutoFixture;
    using Core;
    using NSubstitute;
    using RestSharp;

    public abstract class ClientBaseTest
    {
        protected readonly IRestClient Client;
        protected readonly IClientConfig Config;
        protected readonly Fixture Fixture;

        protected ClientBaseTest()
        {
            Fixture = new Fixture();
            Config = Substitute.For<IClientConfig>();
            Config.ConsumerKey.Returns("K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX");
            Config.ApiRootUrl.Returns("https://app.ticketmaster.com/discovery/");
            Client = new RestClient(Config.ApiRootUrl);
        }
    }
}