using bts.Domain;
using bts.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Iperson _p;

        public ValuesController(Iperson p)
        {
            _p = p;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IActionResult> GetListPerson()
        {
            var res = await _p.ListPersons();
            return Ok(res);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var res = await _p.GetById(id);
            return Ok(res);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PersonDto person)
        {
            var res = await _p.Insert(person);
            return Ok(res);
        }

        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
