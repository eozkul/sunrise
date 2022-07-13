using Sunrise.Entities.Main;
using Sunrise.Entities.Profile;
namespace Sunrise.Data.Context;
public class SunriseDbContext : DbContext
{
    public SunriseDbContext(DbContextOptions options):base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Block> Blocks { get; set; }
    public DbSet<LookUp> LookUps { get; set; }
    public DbSet<LookUpType> LookUpTypes { get; set; }
    public DbSet<SystemParameter> SystemParameters { get; set; }

}

