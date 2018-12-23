namespace Ticketmaster.Publish
{
    using Core;

    public class Config : IClientConfig
    {
        public Config(string consumerKey)
        {
            ConsumerKey = consumerKey;
        }

        public string ConsumerKey { get; }

        public string ApiRootUrl => "https://app.ticketmaster.com/publish/";
    }
}
