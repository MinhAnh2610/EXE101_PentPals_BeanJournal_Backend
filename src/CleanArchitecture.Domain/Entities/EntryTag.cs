namespace CleanArchitecture.Domain.Entities;

public class EntryTag
{
  public string EntryId { get; set; } = default!;
  public Entry Entry { get; set; } = default!;
  public string TagId { get; set; } = default!;
  public Tag Tag { get; set; } = default!; 
}
