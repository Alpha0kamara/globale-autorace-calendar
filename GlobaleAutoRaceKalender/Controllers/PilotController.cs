using AutoMapper;
using GlobaleAutoRaceKalender.Dal;
using GlobaleAutoRaceKalender.DTO;
using GlobaleAutoRaceKalender.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobaleAutoRaceKalender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotController : ControllerBase
    {
        private readonly GlobalAutoRaceCalendarContext _context;
        private readonly IMapper _mapper;
        public PilotController(GlobalAutoRaceCalendarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //add a new pilot
        [HttpPost]
        public IActionResult Post([FromBody] PilotAddDTO pilot)
        {
            _context.Pilots.Add(_mapper.Map<Pilot>(pilot));
            _context.SaveChanges();
            return Ok(pilot);
        }

        //get all pilots
        [HttpGet]
        public IActionResult GetAllPilots()
        {
            return Ok(_context.Pilots);
        }
        //delete a pilot
        [HttpDelete("{id}")]
        public IActionResult DeletePilotById(int id)
        {
            var pilot = _context.Pilots.Find(id);
            if (pilot == null)
            {
                return NotFound();  
            }
            _context.Pilots.Remove(pilot);
            _context.SaveChanges();
            return Ok(pilot);
        }
    }
}
