// ReSharper disable once CheckNamespace
namespace Ticketmaster.Discovery.Tests.V2
{
    using Core;
    using Discovery.V2;
    using Discovery.V2.Models;
    using NSubstitute;
    using System.Threading.Tasks;
    using Xunit;

    public class DiscoveryClientTests
    {
        private readonly DiscoveryApi _sut;

        public DiscoveryClientTests()
        {
            var config = Substitute.For<IClientConfig>();
            config.ConsumerKey.Returns("K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX");
            config.ApiRootUrl.Returns("https://app.ticketmaster.com/discovery/");
            IClientFactory factory = new ClientFactory();
            _sut = factory.Create<DiscoveryApi>(config);
        }

        [Fact]
        public void ClientFactory_ShouldCreate_DiscoveryApi()
        {
            Assert.NotNull(_sut);
            Assert.IsType<DiscoveryApi>(_sut);
            Assert.NotNull(_sut.Events);
            Assert.IsType<EventsClient>(_sut.Events);
            Assert.NotNull(_sut.Attractions);
            Assert.IsType<AttractionsClient>(_sut.Attractions);
            Assert.NotNull(_sut.Venues);
            Assert.IsType<VenuesClient>(_sut.Venues);
            Assert.NotNull(_sut.Classifications);
            Assert.IsType<ClassificationsClient>(_sut.Classifications);
        }

        [Fact]
        public async Task Events_SearchEventsAsync_ShouldReturnResult()
        {
            var result = await _sut.Events.SearchEventsAsync(new SearchEventsRequest());
            Assert.NotNull(result);
            Assert.NotNull(result._embedded);
            Assert.NotEmpty(result._embedded.Events);
        }
    }
}