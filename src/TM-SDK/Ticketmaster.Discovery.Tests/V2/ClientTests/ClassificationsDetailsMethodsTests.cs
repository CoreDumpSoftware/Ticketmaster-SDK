
using System.Net;
using System.Threading.Tasks;
using AutoFixture;
using NSubstitute;
using RestSharp;
using Ticketmaster.Core;
using Ticketmaster.Discovery.V2;
using Ticketmaster.Discovery.V2.Models;
using Xunit;

namespace Ticketmaster.Discovery.Tests.V2.ClientTests
{
    public class ClassificationsDetailsMethodsTests : MethodTest
    {
        public ClassificationsDetailsMethodsTests()
        {
            _response = Fixture.Create<GetGenreDetailsResponse>();
            Client
                .ExecuteTaskAsync(Arg.Any<IRestRequest>())
                .Returns(new RestResponse
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = _response.ToString()
                });
            Client
                .ExecuteTaskAsync<GetGenreDetailsResponse>(Arg.Any<IRestRequest>())
                .Returns(new RestResponse<GetGenreDetailsResponse>
                {
                    Data = _response,
                    StatusCode = HttpStatusCode.OK
                });
            _sut = new ClassificationsClient(Client, Config);
        }

        private readonly ClassificationsClient _sut;
        private readonly GetGenreDetailsResponse _response;

        [Fact]
        public async Task GetGenreDetailsAsync_ShouldReturnGetGenreDetailsResponse()
        {
            var response = await _sut.GetGenreDetailsAsync(new GetRequest("KnvZfZ7vA71"));
            Assert.NotNull(response);
            Assert.Equal(_response, response);
        }

        [Fact]
        public async Task GetSubGenreDetailsAsync_ShouldReturnGetGenreDetailsResponse()
        {
            var response = await _sut.GetSubGenreDetailsAsync(new GetRequest("KZazBEonSMnZfZ7vFta"));
            Assert.NotNull(response);
            Assert.Equal(_response, response);
        }

        [Fact]
        public async Task CallGetGenreDetailsAsync_ShouldIRestResponse()
        {
            var response = await _sut.CallGetGenreDetailsAsync(new GetRequest("KnvZfZ7vA71"));
            Assert.NotNull(response);
            Assert.IsAssignableFrom<IRestResponse>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(_response.ToString(), response.Content);
        }

        [Fact]
        public async Task CallGetSubGenreDetailsAsync_ShouldIRestResponse()
        {
            var response = await _sut.CallGetSubSegmentDetails(new GetRequest("KZazBEonSMnZfZ7vFta"));
            Assert.NotNull(response);
            Assert.IsAssignableFrom<IRestResponse>(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(_response.ToString(), response.Content);
        }
    }
}
