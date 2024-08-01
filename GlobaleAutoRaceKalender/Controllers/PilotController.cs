using GlobaleAutoRaceKalender.Dal;
using GlobaleAutoRaceKalender.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobaleAutoRaceKalender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotController : ControllerBase
    {
        private readonly GlobalAutoRaceCalendarContext _context;
        public PilotController(GlobalAutoRaceCalendarContext context)
        {
            _context = context;
        }
        //add a new pilot
        [HttpPost]
        public IActionResult Post([FromBody] Pilot pilot)
        {
            _context.Pilots.Add(pilot);
            _context.SaveChanges();
            return Ok(pilot);
        }
    }
}
