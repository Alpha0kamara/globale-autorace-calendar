using AutoMapper;
using GlobaleAutoRaceKalender.Dal;
using GlobaleAutoRaceKalender.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobaleAutoRaceKalender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController: ControllerBase
    {
        private readonly GlobalAutoRaceCalendarContext _context;
        private readonly IMapper _mapper;
        public TeamController(GlobalAutoRaceCalendarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //add new team
        [HttpPost]
        public IActionResult AddNewTeam([FromBody] Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
            return Ok(team);
        }

        //get all teams
        [HttpGet]
        public IActionResult GetAllTeams()
        {
            return Ok(_context.Teams);
        }

        //delete a team by id
        [HttpDelete("{id}")]
        public IActionResult DeleteTeamById(int id)
        {
            var team = _context.Teams.Find(id);
            if (team == null)
            {
                return NotFound();
            }
            _context.Teams.Remove(team);
            _context.SaveChanges();
            return Ok(team);
        }
    }
}
