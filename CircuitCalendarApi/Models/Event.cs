namespace CircuitCalendarApi.Models
{
  public class CalendarEvent
  {
    public int CalendarEventId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public int UserId { get; set; }
  }
}
// public int CalendarId { get; set; }