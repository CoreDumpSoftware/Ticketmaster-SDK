namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;

    public class BaseEvent
    {
        public BaseEvent()
        {
            Images = new List<Image>();
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public bool Test { get; set; }
        public string Url { get; set; }
        public string Locale { get; set; }
        public List<Image> Images { get; set; }
    }
}