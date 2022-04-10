using CheapestFlightSearch.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace CheapestFlightSearch.Repository.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<SearchParams> Searches { get; set; }

    }
}
