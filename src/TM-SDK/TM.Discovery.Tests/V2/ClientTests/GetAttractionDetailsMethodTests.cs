namespace Ticketmaster.Discovery.Tests.V2.ClientTests
{
    using System.Net;
    using System.Threading.Tasks;
    using Discovery.V2;
    using Discovery.V2.Models;
    using NSubstitute;
    using Ploeh.AutoFixture;
    using RestSharp;
    using Xunit;

    public class GetAttractionDetailsMethodTests : MethodTest
    {
        public GetAttractionDetailsMethodTests()
        {
            _expectedResponse = Fixture.Create<Attraction>();
            Client
                .ExecuteTaskAsync<Attraction>(Arg.Any<IRestRequest>())
                .Returns(new RestResponse<Attraction>
                {
                    Data = _expectedResponse,
                    StatusCode = HttpStatusCode.OK
                });
            Client
                .ExecuteTaskAsync(Arg.Any<IRestRequest>())
                .Returns(new RestResponse
                {
                    Content = _expectedResponse.ToString(),
                    StatusCode = HttpStatusCode.OK
                });
            _sut = new AttractionsClient(Client, Config);
        }

        private readonly IAttractionsClient _sut;
        private readonly Attraction _expectedResponse;

        [Fact]
        public async Task CallSearchAttractionsAsync_ShouldReturnISearchResponse()
        {
            var response = await _sut.CallGetAttractionDetailsAsync(new GetRequest("K8vZ9175BhV"));
            Assert.NotNull(response);
            Assert.Equal(_expectedResponse.ToString(), response.Content);
        }

        [Fact]
        public async Task SearchAttractionsAsync_ShouldReturnSearchAttractionsResponse()
        {
            var response = await _sut.GetAttractionDetailsAsync(new GetRequest("K8vZ9175BhV"));
            Assert.NotNull(response);
            Assert.Equal(_expectedResponse, response);
        }
    }
}