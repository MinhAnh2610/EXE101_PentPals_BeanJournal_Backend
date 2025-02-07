namespace CleanArchitecture.Infrastructure.Data.Configuration;

public class AIInsightConfiguration : IEntityTypeConfiguration<AIInsight>
{
  public void Configure(EntityTypeBuilder<AIInsight> builder)
  {
    builder.HasKey(ai => ai.Id);

    builder.HasOne(ai => ai.Entry)
        .WithMany(e => e.AIInsights)
        .HasForeignKey(ai => ai.EntryId)
        .OnDelete(DeleteBehavior.Cascade);

    builder.Property(ai => ai.Sentiment)
        .HasMaxLength(50);

    builder.Property(ai => ai.Keywords)
        .IsRequired();

    builder.Property(ai => ai.MoodAnalysis)
        .IsRequired();

    builder.Property(ai => ai.TrendTag)
        .HasMaxLength(100);
  }
}
