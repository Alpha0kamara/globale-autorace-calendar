using AutoMapper;
using GlobaleAutoRaceKalender.Dal;
using GlobaleAutoRaceKalender.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobaleAutoRaceKalender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly GlobalAutoRaceCalendarContext _context;
        private readonly IMapper _mapper;
        public SeriesController(GlobalAutoRaceCalendarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //add new series
        [HttpPost]
        public IActionResult AddNewSeries([FromBody] Series series)
        {
            _context.Series.Add(series);
            _context.SaveChanges();
            return Ok(series);
        }

        //get all series
        [HttpGet]
        public IActionResult GetAllSeries()
        {
            return Ok(_context.Series);
        }

        //delete a series by id 
        [HttpDelete("{id}")]
        public IActionResult DeleteSerieById(int id)
        {
            var series = _context.Series.Find(id);
            if (series == null)
            {
                return NotFound();
            }
            _context.Series.Remove(series);
            _context.SaveChanges();
            return Ok(series);
        }

    }
}
