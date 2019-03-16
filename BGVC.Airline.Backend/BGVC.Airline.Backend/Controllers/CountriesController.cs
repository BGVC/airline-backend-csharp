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
        // TODO: VC -> BG: Use dependency injection for controller, i.e. create CountriesController constructor with AirlineDBContext parameter

        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            // TODO: VC -> BG: Do not call Initialize.GetContext() but instead the context should be injected into countries controller
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
            // TODO: VC -> BG: Do not call Initialize.GetContext() but instead the context should be injected into countries controller
            // TODO: VC -> BG: This should be SingleOrDefault, and if that is null then return NotFound

            var country = Initialize.GetContext().Countries.Single(x => x.Id == id);
            var result = new
            {
                country.Id,
                country.Name,
                country.Iso
            };

            return Ok(result);
        }

        // TODO: VC -> BG: Please remove Post, Put, Delete because we will not allow programatic change of countries due to our decision that we are seeding it because it's a fixed set of data

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
