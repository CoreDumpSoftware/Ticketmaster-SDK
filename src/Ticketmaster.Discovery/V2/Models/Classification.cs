namespace Ticketmaster.Discovery.V2.Models
{
    using Core;

    public class Classification : IApiResponse
    {
        public bool Primary { get; set; }
        public Segment Segment { get; set; }
        public Genre Genre { get; set; }
        public SubGenre SubGenre { get; set; }
        public Links Links { get; set; }
    }
}