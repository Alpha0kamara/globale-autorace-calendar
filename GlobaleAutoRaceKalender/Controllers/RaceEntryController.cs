using AutoMapper;
using GlobaleAutoRaceKalender.Dal;
using GlobaleAutoRaceKalender.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobaleAutoRaceKalender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceEntryController : ControllerBase
    {
        private readonly GlobalAutoRaceCalendarContext _context;
        private readonly IMapper _mapper;

        public RaceEntryController(GlobalAutoRaceCalendarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // new raceEntry toevoegen
        [HttpPost]
        public IActionResult AddNewRaceEntry([FromBody] RaceEntry raceEntry)
        {
            _context.RaceEntries.Add(raceEntry);
            _context.SaveChanges();
            return Ok(raceEntry);
        }

        //get all raceentries
        [HttpGet]
        public IActionResult GetRaceEntries()
        {
            return Ok(_context.RaceEntries);
        }

        //delete an raceEntry by id
        [HttpDelete]
        public IActionResult DeleteRaceEntries(int id)
        {
           var raceEntry = _context.RaceEntries.Find(id);
            if(raceEntry == null)
            {
                return NotFound( new {message = "This RaceEntry doesn't exist"});
            }
            _context.RaceEntries.Remove(raceEntry);
            _context.SaveChanges();
            return Ok(raceEntry);
        }
    }
}
