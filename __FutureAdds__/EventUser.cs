namespace CircuitCalendarApi.Models
{
    public class EventUser
    {
        public int EventUserId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public User User { get; set; }
        public Event Event { get; set; }
    }
}