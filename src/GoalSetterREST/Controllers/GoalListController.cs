﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using GoalSetterREST.Models;
using Microsoft.AspNetCore.Cors;

namespace GoalSetterREST.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [Route("api/[controller]")]
    public class GoalListController : Controller
    {

        // GET api/values
        [HttpGet]
        public List<GoalListItem> Get()
        {

            
            var arList = new List<GoalListItem>();
            arList.Add(new GoalListItem("item 1", false));
            arList.Add(new GoalListItem("item 2", false));
            arList.Add(new GoalListItem("item 3", false));
            arList.Add(new GoalListItem("item 4", false));
            arList.Add(new GoalListItem("item 5", false));

            
            return arList;

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
