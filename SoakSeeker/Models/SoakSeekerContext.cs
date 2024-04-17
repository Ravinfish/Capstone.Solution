using Microsoft.EntityFrameworkCore;

namespace SoakSeeker.Models;

public class SoakSeekerContext : DbContext
{
  public DbSet<Place> Places { get; set; }
  public SoakSeekerContext(DbContextOptions<SoakSeekerContext> options) : base(options) { }
}