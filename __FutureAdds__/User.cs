namespace CircuitCalendarApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public int EventId { get; set; }
    }

}
// public int CalendarId { get; set; }