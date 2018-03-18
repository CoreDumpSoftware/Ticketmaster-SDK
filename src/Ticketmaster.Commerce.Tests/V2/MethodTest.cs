namespace Ticketmaster.Commerce.Tests.V2
{
    using AutoFixture;
    using Core;
    using NSubstitute;
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
            Config.ConsumerKey.Returns("K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX");
            Config.ApiRootUrl.Returns("https://app.ticketmaster.com/commerce/");
            Client = Substitute.For<IRestClient>();
        }
    }
}
