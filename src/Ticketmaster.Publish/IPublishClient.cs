namespace Ticketmaster.Publish
{
    using System.Threading.Tasks;

    public interface IPublishClient
    {
        Task PublishEventAsync(PublishEventRequest request);
    }
}
