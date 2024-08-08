using AutoMapper;
using GlobaleAutoRaceKalender.Dal;
using GlobaleAutoRaceKalender.DTO;
using GlobaleAutoRaceKalender.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobaleAutoRaceKalender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CircuitController : ControllerBase
    {
        private readonly GlobalAutoRaceCalendarContext _context;
        private readonly IMapper _mapper;
        public CircuitController(GlobalAutoRaceCalendarContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //add a new circuit
        [HttpPost]
        public IActionResult AddNewCircuit([FromBody] CircuitAddDTO circuit)
        {
            _context.Circuits.Add(_mapper.Map<Circuit>(circuit));
            _context.SaveChanges();
            return Ok(circuit);
        }

        // get all circuits
        [HttpGet]
        public IActionResult GetAllCircuits()
        {
            return Ok(_context.Circuits);
        }

        // delete a circuit
        [HttpDelete("{id}")]
        public IActionResult DeleteCircuitById(int id)
        {
            var circuit = _context.Circuits.Find(id);
            if(circuit == null)
            {
                return NotFound();
            }
            _context.Circuits.Remove(circuit);
            _context.SaveChanges();
            return Ok(circuit);
        }
    }
}
