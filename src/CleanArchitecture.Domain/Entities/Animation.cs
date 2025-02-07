namespace CleanArchitecture.Domain.Entities;

public class Animation : Entity<string>
{
  public string EntryId { get; set; } = default!;
  public Entry Entry { get; set; } = default!;
  public string Url { get; set; } = default!;
}
