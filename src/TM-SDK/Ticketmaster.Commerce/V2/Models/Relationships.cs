namespace Ticketmaster.Commerce.V2.Models
{
    using Core;
    using System.Collections.Generic;

    public class Relationships
    {
        public Relationships()
        {
            Offers = new OffersData();
            PriceZones = new PriceZonesData();
            Areas = new AreasData();
        }

        public OffersData Offers { get; set; }
        public PriceZonesData PriceZones { get; set; }
        public AreasData Areas { get; set; }
        public class OffersData
        {
            public OffersData()
            {
                Data = new List<IdTypePair>();
            }

            public List<IdTypePair> Data { get; set; }
        }
        public class PriceZonesData
        {
            public PriceZonesData()
            {
                Data = new List<IdTypePair>();
            }
            public List<IdTypePair> Data { get; set; }
        }
        public class AreasData
        {
            public AreasData()
            {
                Data = new List<IdTypePair>();
            }
            public List<IdTypePair> Data { get; set; }
        }
    }
}
