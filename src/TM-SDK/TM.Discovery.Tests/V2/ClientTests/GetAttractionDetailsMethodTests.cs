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
    public class GetAttractionDetailsMethodTests : MethodTest
    {
        private readonly IAttractionsClient _sut;
        private readonly Attraction _expectedResponse;

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

        [Fact]
        public async Task SearchAttractionsAsync_ShouldReturnSearchAttractionsResponse()
        {
            var response = await _sut.GetAttractionDetailsAsync(new GetRequest("K8vZ9175BhV"));
            Assert.NotNull(response);
            Assert.Equal(_expectedResponse, response);
        }

        [Fact]
        public async Task CallSearchAttractionsAsync_ShouldReturnISearchResponse()
        {
            var response = await _sut.CallGetAttractionDetailsAsync(new GetRequest("K8vZ9175BhV"));
            Assert.NotNull(response);
            Assert.Equal(_expectedResponse.ToString(), response.Content);
        }
    }
}
