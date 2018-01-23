namespace Ticketmaster.Commerce.Tests.V2.ClientsTests
{
    using System.Net;
    using System.Threading.Tasks;
    using AutoFixture;
    using Commerce.V2;
    using Commerce.V2.Models;
    using Core;
    using NSubstitute;
    using RestSharp;
    using Xunit;

    public class GetEventOffersAsyncTests : MethodTest
    {
        private readonly IEventOffersClient _sut;
        private readonly EventOffers _expectedResponse;

        public GetEventOffersAsyncTests()
        {
            _expectedResponse = Fixture.Create<EventOffers>();
            Client
                .ExecuteTaskAsync<EventOffers>(Arg.Any<IRestRequest>())
                .Returns(new RestResponse<EventOffers>
                {
                    Data = _expectedResponse,
                    StatusCode = HttpStatusCode.OK
                });
            Client
                .ExecuteTaskAsync(Arg.Any<IRestRequest>())
                .Returns(new RestResponse<EventOffers>
                {
                    Content = _expectedResponse.ToString(),
                    StatusCode = HttpStatusCode.OK
                });
            _sut = new EventOffersClient(Client, Config);
        }

        [Fact]
        public async Task GetEventOffersAsync_ShouldReturnsEventOffers()
        {
            var request = new GetRequest("vvG1fZflTV9p2Q");
            var response = await _sut.GetEventOffersAsync(request);
            Assert.Equal(_expectedResponse, response);
        }

        [Fact]
        public async Task GetEventOffersAsync_ShouldReturnsIRestResponse()
        {
            var request = new GetRequest("vvG1fZflTV9p2Q");
            var response = await _sut.CallGetEventOffersAsync(request);
            Assert.Equal(_expectedResponse.ToString(), response.Content);
        }

        [Fact(Skip = "The Get Event Offers Endpoint returns incorrect response from API.")]
        public async Task GetEventOffersAsync_ShouldReturntRealResult()
        {
            var client = new RestClient(Config.ApiRootUrl);
            var sut = new EventOffersClient(client, Config);
            var result = await sut.GetEventOffersAsync(new GetRequest("vvG17ZfcSx1kbK"));
            Assert.NotNull(result);
        }
    }
}
