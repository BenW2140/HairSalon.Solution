using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }
    public Dbset<Stylist> Stylists { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}