using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BGVC.Airline.Backend.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        private readonly AirlineDBContext _dbContext;

        public CitiesController(AirlineDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            var cities = _dbContext.Municipalities.ToList();
            return Ok(cities);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var city = _dbContext.Municipalities.Single(x => x.Id == id);
            return Ok(city);
        }
    }
}
