
using NSubstitute;
using Ploeh.AutoFixture;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using TM.Discovery.V2;
using TM.Discovery.V2.Models;
using Xunit;

namespace TM.Discovery.Tests.V2.ClientTests
{
    public class GetEventImagesMethodTests : MethodTest
    {

        private readonly EventsClient _sut;

        private readonly GetEventImagesResponse _expectedResult;

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

        [Fact]
        public async Task GetEventImagesAsync_ShouldReturnGetEventImagesResponse()
        {
            var response = await _sut.GetEventImagesAsync(new GetRequest("Z1lMVSyiJynZ177dJa"));
            Assert.NotNull(response);
            Assert.Equal(_expectedResult, response);
        }

        [Fact]
        public async Task CallGetEventImagesAsync_ShouldReturnIRstResponse()
        {
            var response = await _sut.CallGetEventImagesAsync(new GetRequest("Z1lMVSyiJynZ177dJa"));
            Assert.NotNull(response);
            Assert.IsType<RestResponse>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Content);
        }
    }
}
