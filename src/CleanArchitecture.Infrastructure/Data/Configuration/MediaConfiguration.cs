namespace CleanArchitecture.Infrastructure.Data.Configuration;

public class MediaConfiguration : IEntityTypeConfiguration<Media>
{
  public void Configure(EntityTypeBuilder<Media> builder)
  {
    builder.HasKey(m => m.Id);

    builder.HasOne(m => m.Entry)
        .WithMany(e => e.Medias)
        .HasForeignKey(m => m.EntryId)
        .OnDelete(DeleteBehavior.Cascade);

    builder.Property(m => m.Type)
        .IsRequired()
        .HasMaxLength(50);

    builder.Property(m => m.Url)
        .IsRequired();
  }
}
