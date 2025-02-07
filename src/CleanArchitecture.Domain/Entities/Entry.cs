namespace CleanArchitecture.Domain.Entities;

public class Entry : Entity<string>
{
  public string UserId { get; set; } = default!;
  public User User { get; set; } = default!;
  public string Title { get; set; } = default!;
  public string Content { get; set; } = default!;
  public string Mood { get; set; } = default!;
  public List<Media> Medias { get; set; } = new List<Media>();
  public List<EntryTag> EntryTags { get; set; } = new List<EntryTag>();
  public List<AIInsight> AIInsights { get; set; } = new List<AIInsight>();
}
