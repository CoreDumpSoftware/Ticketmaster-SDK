namespace Ticketmaster.Commerce.V2.Models
{
    using Core;

    public class Price : IdTypePair
    {
        public Price()
        {
            Attributes = new CurrencyValuePair();
            Relationships = new RelationshipsClass();
        }

        public CurrencyValuePair Attributes { get; set; }
        public RelationshipsClass Relationships { get; set; }
    }
}
