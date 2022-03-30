using Microsoft.EntityFrameworkCore;
using Shared.Models;
#nullable disable
namespace Server
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Person>  People{ get; set; }
  }
}
