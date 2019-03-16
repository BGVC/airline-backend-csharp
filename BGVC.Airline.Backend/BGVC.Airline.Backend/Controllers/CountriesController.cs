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
        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            var countries = Initialize.GetContext().Countries.Select(country =>
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
            var country = Initialize.GetContext().Countries.Single(x => x.Id == id);
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
