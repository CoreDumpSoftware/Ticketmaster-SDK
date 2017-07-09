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

    public class GetEventImagesMethodTests : MethodTest
    {
        public GetEventImagesMethodTests()
        {
            _expectedResult = Fixture.Create<GetEventImagesResponse>();

            Client
                .ExecuteTaskAsync<GetEventImagesResponse>(Arg.Any<IRestRequest>())
                .Returns(new RestResponse<GetEventImagesResponse>
                {
                    Data = _expectedResult,
                    StatusCode = HttpStatusCode.OK
                });
            Client
                .ExecuteTaskAsync(Arg.Any<IRestRequest>())
                .Returns(new RestResponse
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = "{jobject: { this: 1 }}"
                });
            _sut = new EventsClient(Client, Config);
        }

        private readonly EventsClient _sut;

        private readonly GetEventImagesResponse _expectedResult;

        [Fact]
        public async Task CallGetEventImagesAsync_ShouldReturnIRstResponse()
        {
            var response = await _sut.CallGetEventImagesAsync(new GetRequest("Z1lMVSyiJynZ177dJa"));
            Assert.NotNull(response);
            Assert.IsType<RestResponse>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Content);
        }

        [Fact]
        public async Task GetEventImagesAsync_ShouldReturnGetEventImagesResponse()
        {
            var response = await _sut.GetEventImagesAsync(new GetRequest("Z1lMVSyiJynZ177dJa"));
            Assert.NotNull(response);
            Assert.Equal(_expectedResult, response);
        }
    }
}