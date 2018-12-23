namespace Ticketmaster.Core.V2.Models
{
    using Core;

    public class Product : IdNamePair
    {
        public string Url { get; set; }
        public string Type { get; set; }
    }
}
