namespace CleanArchitecture.Infrastructure.Data.Configuration;

public class AnimationConfiguration : IEntityTypeConfiguration<Animation>
{
  public void Configure(EntityTypeBuilder<Animation> builder)
  {
    builder.HasKey(a => a.Id);

    builder.HasOne(a => a.Entry)
        .WithOne()
        .HasForeignKey<Animation>(a => a.EntryId)
        .OnDelete(DeleteBehavior.Cascade);

    builder.Property(a => a.Url)
        .IsRequired();
  }
}
