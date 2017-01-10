using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalSetterREST.Models
{
    public class GoalListItem
    {
        public GoalListItem()
        {

        }
        public GoalListItem(string projName, string name, bool itemChecked)
        {
            this.projName = projName;
            this.name = name;
            this.itemChecked = itemChecked;
        }
        
        public string name { get; set; }

        public bool itemChecked { get; set; }

        public int id { get; set; }

        public string projName { get; set; }

  
    }
}
