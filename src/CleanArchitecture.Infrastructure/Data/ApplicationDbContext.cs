using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;

namespace CleanArchitecture.Infrastructure.Data;

public interface IApplicationDbContext
{
  DbSet<AIInsight> AIInsights { get; }
  DbSet<Animation> Animations { get; }
  DbSet<Entry> Entries { get; }
  DbSet<EntryTag> EntryTags { get; }
  DbSet<Media> Medias { get; }
  DbSet<Tag> Tags { get; }
  Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

public class ApplicationDbContext : IdentityDbContext<User, Role, string>, IApplicationDbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
  {

  }

  public DbSet<AIInsight> AIInsights => Set<AIInsight>();

  public DbSet<Animation> Animations => Set<Animation>();

  public DbSet<Entry> Entries => Set<Entry>();

  public DbSet<EntryTag> EntryTags => Set<EntryTag>();

  public DbSet<Media> Medias => Set<Media>();

  public DbSet<Tag> Tags => Set<Tag>();

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    base.OnModelCreating(builder);
  }
}
