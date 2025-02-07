namespace CleanArchitecture.Domain.Entities;

public class AIInsight : Entity<string>
{
  public string EntryId { get; set; } = default!;
  public Entry Entry { get; set; } = default!;
  public string Sentiment { get; set; } = default!;
  public string Keywords { get; set; } = default!;
  public string MoodAnalysis { get; set; } = default!;
  public string TrendTag { get; set; } = default!;
}
