namespace Ticketmaster.Commerce.V2.Models
{
    using System.Collections.Generic;

    public class Prices
    {
        public Prices()
        {
            Data = new List<Price>();
        }
        public List<Price> Data { get; set; }
    }
}
