using Microsoft.EntityFrameworkCore;

public class DataBaseContext : DbContext
{
  public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
  public DbSet<Post> Posts { get; set; }
  // public DbSet<Author> Authors { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost:5432;Database=blog;Username=postgres;Password=dbpassword");
}