using Ticketmaster.Core;

namespace Ticketmaster.Discovery.V2.Models
{
    public class PriceRange : MinMaxPair
    {
        public string Type { get; set; }
        public string Currency { get; set; }
    }
}
