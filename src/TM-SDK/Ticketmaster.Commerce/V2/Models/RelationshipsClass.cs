namespace Ticketmaster.Commerce.V2.Models
{
    using Core;

    public class RelationshipsClass
    {
        public DataCollection<IdTypePair> Offers { get; set; }
        public DataCollection<IdTypePair> PriceZones { get; set; }
        public DataCollection<IdTypePair> Areas { get; set; }

    }
}
