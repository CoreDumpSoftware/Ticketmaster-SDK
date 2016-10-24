using NSubstitute;
using Ploeh.AutoFixture;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using TM.Discovery.V2;
using Xunit;

namespace TM.Discovery.Tests.V2.ClientTests
{
    public class SearchClassificationsMethodTests : MethodTest
    {
        private readonly ClassificationsClient _sut;
        private readonly SearchClassificationsResponse _expectedResponse;

        public SearchClassificationsMethodTests()
        {
            var fixture = new Fixture();
            _expectedResponse = fixture.Create<SearchClassificationsResponse>();
            Client
                  .ExecuteTaskAsync<SearchClassificationsResponse>(Arg.Any<IRestRequest>())
                  .Returns(new RestResponse<SearchClassificationsResponse>
                  {
                      Data = _expectedResponse,
                      StatusCode = HttpStatusCode.OK
                  });
            Client
                   .ExecuteTaskAsync(Arg.Any<IRestRequest>())
                   .Returns(new RestResponse
                   {
                       StatusCode = HttpStatusCode.OK,
                       Content = "{jobject: { this: 1 }}"
                   });
            _sut = new ClassificationsClient(Client, Config);
        }

        [Fact]
        public async Task SearchClassificationsAsync_ShouldReturnSearchClassificationsResponse()
        {
            var result = await _sut.SearchClassificationsAsync(new BaseQuery());
            Assert.NotNull(result);
            Assert.Equal(_expectedResponse, result);
        }

        [Fact]
        public async Task SearchClassificationsAsync_ShouldReturnIRestResponse()
        {
            var result = await _sut.CallSearchClassificationsAsync(new BaseQuery());
            Assert.NotNull(result);
            Assert.IsType<RestResponse>(result);
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.NotNull(result.Content);
        }
    }
}
