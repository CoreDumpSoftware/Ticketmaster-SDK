using NSubstitute;
using Ploeh.AutoFixture;
using RestSharp;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using TM.Discovery.V2;
using TM.Discovery.V2.Models;
using Xunit;

namespace TM.Discovery.Tests.V2.ClientTests
{
    public class GetEventDetailsMethodTests : MethodTest
    {

        private readonly EventsClient _sut;
        private readonly Event _expectedResult;

        public GetEventDetailsMethodTests()
        {
            var fixture = new Fixture();
            _expectedResult = fixture.Create<Event>();


            Client
               .ExecuteTaskAsync<Event>(Arg.Any<IRestRequest>())
               .Returns(new RestResponse<Event>
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

        [Theory]
        [InlineData(HttpStatusCode.Accepted)]
        [InlineData(HttpStatusCode.Ambiguous)]
        [InlineData(HttpStatusCode.BadGateway)]
        [InlineData(HttpStatusCode.BadRequest)]
        [InlineData(HttpStatusCode.Conflict)]
        [InlineData(HttpStatusCode.Created)]
        [InlineData(HttpStatusCode.InternalServerError)]
        [InlineData(HttpStatusCode.Continue)]
        [InlineData(HttpStatusCode.ExpectationFailed)]
        [InlineData(HttpStatusCode.GatewayTimeout)]
        [InlineData(HttpStatusCode.Gone)]
        [InlineData(HttpStatusCode.NonAuthoritativeInformation)]
        [InlineData(HttpStatusCode.NotAcceptable)]
        public async Task GetEventDetailsAsync_ShouldThrowException_WhenResponseCodeNotOk(HttpStatusCode statusCode)
        {
            Client
               .ExecuteTaskAsync<Event>(Arg.Any<IRestRequest>())
                   .Returns(new RestResponse<Event>
                   {
                       StatusCode = statusCode
                   });

            await Assert.ThrowsAnyAsync<InvalidDataException>(() => _sut.GetEventDetailsAsync(new Request("invalid id")));


        }

        [Fact]
        public async Task GetEventDetailsAsync_ShouldReturnEvent_IfEventExist()
        {
            var response = await _sut.GetEventDetailsAsync(new Request("Z1lMVSyiJynZ177dJa"));
            Assert.NotNull(response);
            Assert.Equal(_expectedResult, response);
        }

        [Fact]
        public async Task CallGetEventDetailsAsync_ShouldReturnIRestResponse()
        {
            var response = await _sut.CallGetEventDetailsAsync(new Request("Z1lMVSyiJynZ177dJa"));
            Assert.NotNull(response);
            Assert.IsType<RestResponse>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Content);
        }
    }
}
