
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
    public class SearchVenuesMethodTests : MethodTest
    {
        private readonly VenuesClient _sut;
        private readonly SearchVenuesResponse _response;

        public SearchVenuesMethodTests()
        {
            _response = Fixture.Create<SearchVenuesResponse>();
            Client
                .ExecuteTaskAsync<SearchVenuesResponse>(Arg.Any<IRestRequest>())
                .Returns(new RestResponse<SearchVenuesResponse>
                {
                    Data = _response,
                    StatusCode = HttpStatusCode.OK
                });
            Client
                .ExecuteTaskAsync(Arg.Any<IRestRequest>())
                .Returns(new RestResponse
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = _response.ToString()
                });
            _sut = new VenuesClient(Client, Config);
        }

        [Fact]
        public async Task SearchVenuesAsync_ShouldReturnSearchVenuesResponse()
        {
            var response = await _sut.SearchVenuesAsync(new SearchVenuesRequest());
            Assert.NotNull(response);
            Assert.Equal(_response, response);
        }

        [Fact]
        public async Task CallSearchVenuesAsync_ShouldReturnSearchVenuesResponse()
        {
            var response = await _sut.CallSearchVenuesAsync(new SearchVenuesRequest());
            Assert.NotNull(response);
            Assert.Equal(_response.ToString(), response.Content);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
