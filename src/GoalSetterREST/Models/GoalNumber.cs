using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalSetterREST.Models
{
    public class GoalNumber
    {
        public GoalNumber()
        {

        }
        public int target { get; set; }

        public int current { get; set; }

        public string name { get; set; }
        
        public int id { get; set; }
    }
}
