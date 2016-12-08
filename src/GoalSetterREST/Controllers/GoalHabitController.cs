using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using GoalSetterREST.Models;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GoalSetterREST.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [Route("api/[controller]")]
    public class GoalHabitController : Controller
    {
        // GET: api/values
        [HttpGet]
        public GoalHabit Get()
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13); // creates a number between 1 and 12
            int card = rnd.Next(52); // creates a number between 0 and 51

            return new Models.GoalHabit { name = "Habit " + month, numberTimes = card };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
