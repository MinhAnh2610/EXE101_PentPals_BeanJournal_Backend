namespace CleanArchitecture.Infrastructure.Data.Configuration;

public class EntryConfiguration : IEntityTypeConfiguration<Entry>
{
  public void Configure(EntityTypeBuilder<Entry> builder)
  {
    builder.HasKey(e => e.Id);

    builder.HasOne(e => e.User)
        .WithMany(u => u.Entries)
        .HasForeignKey(e => e.UserId)
        .OnDelete(DeleteBehavior.Cascade);

    builder.Property(e => e.Title)
        .IsRequired()
        .HasMaxLength(255);

    builder.Property(e => e.Content)
        .IsRequired();

    builder.Property(e => e.Mood)
        .HasMaxLength(100);

    builder.HasMany(e => e.Medias)
        .WithOne(m => m.Entry)
        .HasForeignKey(m => m.EntryId)
        .OnDelete(DeleteBehavior.Cascade);
  }
}
