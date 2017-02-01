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
            using (var db = new GoalSetterContext())
            {


                var goalHabit = db.GoalHabits.First();

                return goalHabit;
            }
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(string times)
        {
            int currNum = Convert.ToInt32(times);

            using (var db = new GoalSetterContext())
            {
                // For now, pull them and update them all, but eventually we will switch to per unit.
                var allnums = db.Set<GoalHabit>();
                foreach (var row in allnums)
                {
                    row.numberTimes = currNum;
                }
                db.SaveChanges();

            }
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
