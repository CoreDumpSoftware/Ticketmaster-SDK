namespace TM.Discovery
{
    public interface IDiscoveryApiGetRequest : IDiscoveryApiRequest
    {
        string Id { get; set; }
    }
}
