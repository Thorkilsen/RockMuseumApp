using Microsoft.EntityFrameworkCore;

namespace RockMuseumApp
{
    public class MuseumContext : DbContext
    {
        public MuseumContext(DbContextOptions<MuseumContext> options)
            : base(options)
        {
        }

        public DbSet<Udstilling> Udstillinger { get; set; }
        public DbSet<Lydguide> Lydguides { get; set; }
    }

    public class Udstilling
    {
        public int Id { get; set; }
        public string? Navn { get; set; }
        public string? Beskrivelse { get; set; }
    }

    public class Lydguide
    {
        public int Id { get; set; }
        public string? Titel { get; set; }
        public int UdstillingId { get; set; }
        public Udstilling? Udstilling { get; set; }
        public string? Fil { get; set; }
    }
}






