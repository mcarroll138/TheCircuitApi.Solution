using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CircuitCalendarApi.Models;

namespace CircuitCalendarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarEventsController : ControllerBase
    {
        private readonly CircuitCalendarApiContext _db;

        public CalendarEventsController(CircuitCalendarApiContext db)
        {
            _db = db;
        }

        // Get api/calendarEvents
        [HttpGet]
        public async Task<List<CalendarEvent>> Get(string name, string description)
        {
            IQueryable<CalendarEvent> query = _db.CalendarEvents.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name.Contains(name));
            }
            if (description != null)
            {
                query = query.Where(entry => entry.Description.Contains(description));
            }
            return await query.ToListAsync();
        }

        //Get: api/CalendarEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarEvent>> GetCalendarEvent(int id)
        {
            CalendarEvent calendarEvent = await _db.CalendarEvents.FindAsync(id);
            if (calendarEvent == null)
            {
                return NotFound();
            }
            return calendarEvent;
        }

        //Post api/CalendarEvents
        [HttpPost]
        public async Task<ActionResult<CalendarEvent>> Post(CalendarEvent calendarEvent)
        {
            _db.CalendarEvents.Add(calendarEvent);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCalendarEvent), new { id = calendarEvent.CalendarEventId }, calendarEvent);
        }

        //Put: api/CalendarEvents/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CalendarEvent calendarEvent)
        {
            if (id != calendarEvent.CalendarEventId)
            {
                return BadRequest();
            }
            _db.CalendarEvents.Update(calendarEvent);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalendarEventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        private bool CalendarEventExists(int id)
        {
            return _db.CalendarEvents.Any(e => e.CalendarEventId == id);
        }

        //DELETE: api/calendarevents/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalendarEvent(int id)
        {
            CalendarEvent calendarEvent = await _db.CalendarEvents.FindAsync(id);
            if (calendarEvent == null)
            {
                return NotFound();
            }

            _db.CalendarEvents.Remove(calendarEvent);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }

}


