namespace CleanArchitecture.Domain.Entities;

public class Tag : Entity<string>
{
  public string Name { get; set; } = default!;
  public List<EntryTag> EntryTags { get; set; } = new List<EntryTag>();
}
