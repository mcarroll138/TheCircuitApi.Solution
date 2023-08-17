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

        // Get Events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalendarEvent>>> GetCalendarEvents()
        {
            return await _db.CalendarEvents.ToListAsync();
        }

        // [HttpGet("{id}")]
        // public async Task<ActionResult<CalendarEvent>> GetCalendarEvent(int id)
        // {
        //     var event = await _db.CalendarEvents.FindAsync(id);

        //     if (event == null)
        //         return NotFound();

        //     return event;
        // }
    }
}

//         //Post
//         [HttpPost]
//         public async Task<ActionResult<Event>> Post(Event event)
//         {
//             _db.Events.Add(event);
//         await _db.SaveChangesAsync();
//             return CreatedAtAction(nameof(GetEvent), new { id = event.EventId }, event);
//         }

//         //Put
//         [HttpPut("{id}")]
//         public async Task<IActionResult> Put(int id, Event event)
//         {
//             if (id != event.EventId)
//             {
//             return BadRequest();
//         }

//         _db.Events.Update(event);

//             try
//             {
//             await _db.SaveChangesAsync();
//         }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!EventExists(id))
//                 {
//                     return NotFound();
//     }
//                 else
//                 {
//                     throw;
//                 }
//             }
//             return NoContent();
//         }

//         private bool EventExists(int id)
// {
//     return _db.Events.Any(e => e.EventId == id);
// }

// // DELETE
// [HttpDelete("{id}")]
// public async Task<IActionResult> DeleteEvent(int id)
// {
//     Event event = await _db.Events.FindAsync(id);
//     if (event == null)
//             {
//     return NotFound();
// }

// _db.Events.Remove(event);
// await _db.SaveChangesAsync();

// return NoContent();
//         }

//     }
// }
