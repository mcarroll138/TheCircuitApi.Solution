using Microsoft.EntityFrameworkCore;

namespace CircuitCalendarApi.Models
{
  public class CircuitCalendarApiContext : DbContext
  {
    // public DbSet<User> Users { get; set; }
    public DbSet<CalendarEvent> CalendarEvents { get; set; }

    public CircuitCalendarApiContext(DbContextOptions<CircuitCalendarApiContext> options) : base(options)
    {

    }
  }
}
// public DbSet<Calendar> Calendars { get; set; }