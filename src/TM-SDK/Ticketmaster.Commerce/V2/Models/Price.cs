namespace Ticketmaster.Commerce.V2.Models
{
    using Core;

    public class Price
    {
        public Price()
        {
            Attributes = new CurrencyValuePair();
            Relationships = new Relationships();
        }

        public string Type { get; set; }
        public CurrencyValuePair Attributes { get; set; }
        public Relationships Relationships { get; set; }
    }
}
