using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalSetterREST.Models
{
    public class GoalHabit
    {
        public GoalHabit()
        {
        }

        public int numberTimes { get; set; }

        public string name { get; set; }

        public int id { get; set;  }
    }
}
