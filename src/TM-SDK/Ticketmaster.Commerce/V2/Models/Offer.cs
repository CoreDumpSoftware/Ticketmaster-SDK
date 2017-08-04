namespace Ticketmaster.Commerce.V2.Models
{
    using Core;
    using System.Collections.Generic;
    public class Offer : IdTypePair
    {
        public AttributesClass Attributes { get; set; }
        public RelationshipsClass Relationships { get; set; }

        public class AttributesClass
        {
            public AttributesClass()
            {
                Prices = new List<Price>();
            }

            public string Name { get; set; }
            public string Description { get; set; }
            public int Rank { get; set; }
            public string OfferType { get; set; }
            public string Currency { get; set; }
            public List<Price> Prices { get; set; }
            public Limits Limit { get; set; }

            public class Price
            {
                public Price()
                {
                    Fees = new List<InnerData>();
                    Taxes = new List<InnerData>();
                }

                public string PriceZone { get; set; }
                public string Value { get; set; }
                public string Total { get; set; }
                public List<InnerData> Fees { get; set; }
                public List<InnerData> Taxes { get; set; }

                public class InnerData
                {
                    public string Value { get; set; }
                    public string Label { get; set; }
                    public string Type { get; set; }
                }

            }
        }

        public class RelationshipsClass
        {
            public IdTypePairCollectionData Areas { get; set; }
            public IdTypePairCollectionData PriceZones { get; set; }
            public IdTypePairCollectionData Products { get; set; }

        }
    }
}
