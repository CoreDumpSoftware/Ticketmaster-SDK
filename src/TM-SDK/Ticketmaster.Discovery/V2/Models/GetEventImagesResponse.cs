namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;
    using Core;

    public class GetEventImagesResponse : IApiResponse
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public Links Links { get; set; }
    }
}