using NSubstitute;
using Ploeh.AutoFixture;
using RestSharp;

namespace TM.Discovery.Tests.V2
{
    public abstract class MethodTest
    {
        protected readonly IClientConfig Config;
        protected readonly IRestClient Client;
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
