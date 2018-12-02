// ReSharper disable once CheckNamespace

namespace Ticketmaster.Discovery
{
    using Core;
    using RestSharp;
    using System;
    using V2;

    /// <summary>
    ///     Defines the <see cref="DiscoveryApi" />
    /// </summary>
    public class DiscoveryApi : IDiscoveryClient
    {
        /// <summary>
        ///     Defines the ExceptionPattern
        /// </summary>
        private const string ExceptionPattern = "You try to access {0} client without it initialization";

        /// <summary>
        ///     Defines the _attractions
        /// </summary>
        private IAttractionsClient _attractions;

        /// <summary>
        ///     Defines the _classifications
        /// </summary>
        private IClassificationsClient _classifications;

        /// <summary>
        ///     Defines the _events
        /// </summary>
        private IEventsClient _events;

        /// <summary>
        ///     Defines the _venues
        /// </summary>
        private IVenuesClient _venues;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DiscoveryApi" /> class.
        /// </summary>
        public DiscoveryApi()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DiscoveryApi" /> class.
        /// </summary>
        /// <param name="events">The events<see cref="IEventsClient" /></param>
        /// <param name="venues">The venues<see cref="IVenuesClient" /></param>
        /// <param name="attractions">The attractions<see cref="IAttractionsClient" /></param>
        /// <param name="classifications">The classifications<see cref="IClassificationsClient" /></param>
        public DiscoveryApi(
            IEventsClient events,
            IVenuesClient venues,
            IAttractionsClient attractions,
            IClassificationsClient classifications)
        {
            _events = events;
            _venues = venues;
            _attractions = attractions;
            _classifications = classifications;
        }

        /// <summary>
        ///     The Configure
        /// </summary>
        /// <param name="config">The config<see cref="IClientConfig" /></param>
        /// <returns>The <see cref="IApiClient" /></returns>
        public IApiClient Configure(IClientConfig config)
        {
            var client = new RestClient(config.ApiRootUrl);
            _events = new EventsClient(client, config);
            _venues = new VenuesClient(client, config);
            _attractions = new AttractionsClient(client, config);
            _classifications = new ClassificationsClient(client, config);

            return this;
        }

        /// <summary>
        ///     Gets or sets the Events
        /// </summary>
        public IEventsClient Events
        {
            get => _events ?? throw new NullReferenceException(string.Format(ExceptionPattern, nameof(Events)));
            protected set => _events = value;
        }

        /// <summary>
        ///     Gets or sets the Venues
        /// </summary>
        public IVenuesClient Venues
        {
            get => _venues ?? throw new NullReferenceException(string.Format(ExceptionPattern, nameof(Venues)));
            protected set => _venues = value;
        }

        /// <summary>
        ///     Gets or sets the Attractions
        /// </summary>
        public IAttractionsClient Attractions
        {
            get => _attractions ??
                   throw new NullReferenceException(string.Format(ExceptionPattern, nameof(Attractions)));
            protected set => _attractions = value;
        }

        /// <summary>
        ///     Gets or sets the Classifications
        /// </summary>
        public IClassificationsClient Classifications
        {
            get => _classifications ??
                   throw new NullReferenceException(string.Format(ExceptionPattern, nameof(Classifications)));
            protected set => _classifications = value;
        }
    }
}