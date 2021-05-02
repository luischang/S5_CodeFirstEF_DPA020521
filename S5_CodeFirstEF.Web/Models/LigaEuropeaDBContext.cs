using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S5_CodeFirstEF.Web.Models
{
    public class LigaEuropeaDBContext: DbContext
    {

        public LigaEuropeaDBContext(DbContextOptions<LigaEuropeaDBContext> options): base(options)
        {

        }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }

        public DbSet<SoccerPosition> SoccerPosition { get; set; }

    }
}
