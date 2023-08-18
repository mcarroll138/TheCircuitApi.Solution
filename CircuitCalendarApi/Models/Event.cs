using System.ComponentModel.DataAnnotations;

namespace CircuitCalendarApi.Models
{
  public class CalendarEvent
  {
    public int CalendarEventId { get; set; }
    [Required]
    [StringLength(40)]
    public string Name { get; set; }
    [Required]
    [StringLength(5000)]
    public string Description { get; set; }
  }
}
// // public DateTime EventDateTime { get; set; }
// public int UserId { get; set; }
// public int CalendarId { get; set; }