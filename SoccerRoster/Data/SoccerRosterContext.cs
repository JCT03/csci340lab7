using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoccerRoster.Models;

namespace SoccerRoster.Data
{
    public class SoccerRosterContext : DbContext
    {
        public SoccerRosterContext (DbContextOptions<SoccerRosterContext> options)
            : base(options)
        {
        }

        public DbSet<SoccerRoster.Models.Player> Player { get; set; } = default!;
    }
}
