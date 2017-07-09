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

    public class GetClassificationDetailsMethodTests : MethodTest
    {
        public GetClassificationDetailsMethodTests()
        {
            _classification = Fixture.Create<Classification>();

            Client
                .ExecuteTaskAsync<Classification>(Arg.Any<IRestRequest>())
                .Returns(new RestResponse<Classification>
                {
                    Data = _classification,
                    StatusCode = HttpStatusCode.OK
                });

            Client
                .ExecuteTaskAsync(Arg.Any<IRestRequest>())
                .Returns(new RestResponse
                {
                    Content = _classification.ToString(),
                    StatusCode = HttpStatusCode.OK
                });

            _sut = new ClassificationsClient(Client, Config);
        }

        private readonly ClassificationsClient _sut;
        private readonly Classification _classification;

        [Fact]
        public async Task CallGetClassificationDetailsAsync_ShouldReturnIRestResponse()
        {
            var result = await _sut.CallGetClassificationDetailsAsync(new GetRequest(""));
            Assert.NotNull(result);
            Assert.IsType<RestResponse>(result);
            Assert.Equal(_classification.ToString(), result.Content);
        }

        [Fact]
        public async Task GetClassificationDetailsAsync_ShouldReturnClassification()
        {
            var result = await _sut.GetClassificationDetailsAsync(new GetRequest(""));
            Assert.Equal(_classification, result);
        }
    }
}