using AutoMapper;
using GlobaleAutoRaceKalender.Dal;
using GlobaleAutoRaceKalender.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobaleAutoRaceKalender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeasonController : ControllerBase
    {
        private readonly GlobalAutoRaceCalendarContext _context;
        private readonly IMapper _mapper;

        public SeasonController(GlobalAutoRaceCalendarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //add new season
        [HttpPost]
        public IActionResult AddNewSeason([FromBody] Season season)
        {
            _context.Seasons.Add(season);
            _context.SaveChanges();
            return Ok(season);
        }

        //get all seasons 
        [HttpGet]
        public IActionResult GetAllSeasons()
        {
            return Ok(_context.Seasons);
        }

        //delete a season by id
        [HttpDelete]
        public IActionResult DeleteSeason(int id)
        {
            var season = _context.Seasons.Find(id);
            if (season == null)
            {
                return NotFound();
            }
            _context.Seasons.Remove(season);
            _context.SaveChanges();
            return Ok(season);
        }
    }
}
