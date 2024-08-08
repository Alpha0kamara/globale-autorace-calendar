using AutoMapper;
using GlobaleAutoRaceKalender.Dal;
using GlobaleAutoRaceKalender.DTO;
using GlobaleAutoRaceKalender.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobaleAutoRaceKalender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly GlobalAutoRaceCalendarContext _context;
        private readonly IMapper _mapper;
        public RaceController(GlobalAutoRaceCalendarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //add new race
        [HttpPost]
        public IActionResult AddNewRace([FromBody] RaceAddDTO raceAddDTO)
        {
            _context.Races.Add(_mapper.Map<Race>(raceAddDTO));
            _context.SaveChanges();
            return Ok(raceAddDTO);
        }

        //get all races
        [HttpGet]
        public IActionResult GetAllRaces()
        {
            return Ok(_context.Races);
        }

        // delete a race by id
        [HttpDelete("{id}")]
        public IActionResult DeleteRaceById(int id)
        {
            var race = _context.Races.Find(id);
            if (race == null)
            {
                return NotFound();
            }
            return Ok(race);
        }

    }
}
