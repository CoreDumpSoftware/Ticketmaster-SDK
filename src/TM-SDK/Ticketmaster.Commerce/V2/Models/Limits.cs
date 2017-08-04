namespace Ticketmaster.Commerce.V2.Models
{
    public class Limits
    {
        public int Max { get; set; }
        public int Min { get; set; }
        public int Multiples { get; set; }
        public int MaxAccessibleSeats { get; set; }
        public int MaxCompanionSeatsPerAccessibleSeat { get; set; }
    }
}
