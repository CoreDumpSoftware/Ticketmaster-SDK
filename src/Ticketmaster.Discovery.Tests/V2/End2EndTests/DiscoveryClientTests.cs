// ReSharper disable once CheckNamespace
namespace Ticketmaster.Discovery.Tests.V2
{
    using Core;
    using Discovery.V2;
    using Discovery.V2.Models;
    using NSubstitute;
    using RestSharp;
    using System.Threading.Tasks;
    using Xunit;

    public class DiscoveryClientTests
    {
        private readonly DiscoveryApi _sut;
        private readonly IEventsClient _events;
        private readonly IVenuesClient _venues;
        private readonly IAttractionsClient _attractions;
        private readonly IClassificationsClient _classifications;
        private readonly IClientConfig _config;
        private readonly IClientFactory _factory;

        public DiscoveryClientTests()
        {
            _config = Substitute.For<IClientConfig>();
            _config.ConsumerKey.Returns("K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX");
            _config.ApiRootUrl.Returns("https://app.ticketmaster.com/discovery/");
            _events = new EventsClient(new RestClient(_config.ApiRootUrl), _config);
            _sut = new DiscoveryApi(_events, _venues, _attractions, _classifications);
            _factory = new ClientFactory();
        }

        [Fact]
        public async Task SearchEventsAsync_()
        {
            var result = await _sut
                .Events
                .SearchEventsAsync(
                    new SearchEventsRequest()
                        .AddQueryParameter(SearchEventsQueryParameters.city, "Wroclaw"));

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Create()
        {
            var result = await _factory.Create<DiscoveryApi>(_config)
                .Events
                .SearchEventsAsync(
                    new SearchEventsRequest()
                        .AddQueryParameter(SearchEventsQueryParameters.city, "Wroclaw"));

            Assert.NotNull(result);
        }
    }
}