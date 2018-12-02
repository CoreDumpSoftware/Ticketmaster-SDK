namespace Ticketmaster.Core
{
    public interface IApiClient
    {
        IApiClient Configure(IClientConfig config);

        //Task<TResponse> SearchAsync<TResponse>(Action<IApiGetRequest> request) where TResponse : IApiResponse;
    }
}
