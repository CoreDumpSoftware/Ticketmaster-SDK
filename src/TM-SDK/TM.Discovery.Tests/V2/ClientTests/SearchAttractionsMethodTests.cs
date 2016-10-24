using NSubstitute;
using Ploeh.AutoFixture;
using RestSharp;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TM.Discovery.V2;
using TM.Discovery.V2.Models;
using Xunit;

namespace TM.Discovery.Tests.V2.ClientTests
{
    public class SearchAttractionsMethodTests : MethodTest
    {
        private readonly AttractionsClient _sut;
        private readonly SearchAttractionsResponse _expectedResponse;


        public SearchAttractionsMethodTests()
        {
            _expectedResponse = Fixture.Create<SearchAttractionsResponse>();

            Client
               .ExecuteTaskAsync<SearchAttractionsResponse>(Arg.Any<IRestRequest>())
               .Returns(new RestResponse<SearchAttractionsResponse>
               {
                   Data = _expectedResponse,
                   StatusCode = HttpStatusCode.OK
               });
            _sut = new AttractionsClient(Client, Config);
        }

        [Fact]
        public async Task SearchAttractionsAsync_ShouldReturnSearchAttractionsResponse()
        {
            var response = await _sut.SearchAttractionsAsync(new BaseQuery());
            Assert.NotNull(response);
            Assert.Equal(_expectedResponse, response);
        }

        [Theory]
        [InlineData("size", "1")]
        [InlineData("page", "1")]
        public async Task SearchAttractionsAsync_ShouldBuildRequestWithQueryParameters(string key, string value)
        {
            var request = new BaseQuery();
            request.QueryParameters.Add(key, value);

            await _sut.SearchAttractionsAsync(request);

            await Client
                .Received()
                .ExecuteTaskAsync<SearchAttractionsResponse>(
                    Arg.Is<RestRequest>(
                        restRequest => restRequest.Parameters.Any(p => p.Name == key && Equals(p.Value, value))));
        }
    }
}
