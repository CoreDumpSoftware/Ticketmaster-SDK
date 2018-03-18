using Ticketmaster.Core;

namespace Ticketmaster.Commerce.V2.Models
{
    public class EmbeddedData : IdTypePair
    {
        public AttributesClass Attributes { get; set; }
        public RelationshipsClass Relationships { get; set; }
        public dynamic MetaData { get; set; }
    }
}
