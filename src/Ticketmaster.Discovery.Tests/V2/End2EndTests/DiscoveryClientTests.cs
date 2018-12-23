// ReSharper disable once CheckNamespace
namespace Ticketmaster.Discovery.Tests.V2
{
    using Core;
    using Discovery.V2;
    using Discovery.V2.Models;
    using NSubstitute;
    using System;
    using System.Threading.Tasks;
    using Xunit;

    public class DiscoveryClientTests
    {
        private readonly DiscoveryApi _sut;
        private readonly IClientFactory _factory;
        private readonly IClientConfig _config;

        public DiscoveryClientTests()
        {
            _config = Substitute.For<IClientConfig>();
            _config.ConsumerKey.Returns("K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX");
            _config.ApiRootUrl.Returns("https://app.ticketmaster.com/discovery/");
            _factory = new ClientFactory();
            _sut = _factory.Create<DiscoveryApi>(_config);
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
            SearchEventsResponse result;

            using (var sut = _factory.Create<DiscoveryApi>(_config))
            {
                result = await sut.Events.SearchEventsAsync(new SearchEventsRequest());
            }

            Assert.NotNull(result);
            Assert.NotNull(result._embedded);
            Assert.NotEmpty(result._embedded.Events);
        }

        [Fact]
        public void DiscoveryApi_Properties_ShouldThrow_NullReferenceException_WhenNot()
        {
            var api = new DiscoveryApi();

            Assert.Throws<NullReferenceException>(() => api.Events);
            Assert.Throws<NullReferenceException>(() => api.Attractions);
            Assert.Throws<NullReferenceException>(() => api.Classifications);
            Assert.Throws<NullReferenceException>(() => api.Venues);
        }
    }
}