using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BGVC.Airline.Backend.Controllers
{
    [Route("api/[controller]")]
    public class CountriesController : Controller
    {
        private readonly AirlineDBContext _dbContext;

        public CountriesController(AirlineDBContext context)
        {
            _context = context;
        }

        // TODO: VC -> BG: Private should go at top, and make this readonly
        private AirlineDBContext _context;

        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            var countries = _context.Countries.Select(country =>
                new
                {
                    country.Id,
                    country.Name,
                    country.Iso
                }).ToList();

            return Ok(countries);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            // TODO: VC -> BG: Do not use Initialize.GetContext() but instead use the injected context
            // TODO: VC -> BG: Do not use Single here instead use SingleOrDefault because if it does not exist, should return NotFound (instead of exception)

            var country = _dbContext.Countries.Single(x => x.Id == id);

            var result = new
            {
                country.Id,
                country.Name,
                country.Iso
            };

            return Ok(result);
        }
    }
}
