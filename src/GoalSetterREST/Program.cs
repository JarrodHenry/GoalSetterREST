using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using GoalSetterREST.Models;
using System.Data.Entity;

namespace GoalSetterREST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }

    public class GoalSetterContext : DbContext
    {
        public DbSet<GoalNumber> GoalNumbers { get; set; }
        public DbSet<GoalListItem> GoalListItems { get; set; }
        public DbSet<GoalHabit> GoalHabits { get; set; }
    }
}
