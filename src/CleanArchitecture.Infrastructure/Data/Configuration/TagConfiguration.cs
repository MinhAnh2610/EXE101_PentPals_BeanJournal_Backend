namespace CleanArchitecture.Infrastructure.Data.Configuration;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
  public void Configure(EntityTypeBuilder<Tag> builder)
  {
    builder.HasKey(t => t.Id);

    builder.Property(t => t.Name)
        .IsRequired()
        .HasMaxLength(100);

    builder.HasMany(t => t.EntryTags)
        .WithOne(et => et.Tag)
        .HasForeignKey(et => et.TagId)
        .OnDelete(DeleteBehavior.Cascade);
  }
}
