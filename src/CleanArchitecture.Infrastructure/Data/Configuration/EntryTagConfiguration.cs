﻿namespace CleanArchitecture.Infrastructure.Data.Configuration;

public class EntryTagConfiguration : IEntityTypeConfiguration<EntryTag>
{
  public void Configure(EntityTypeBuilder<EntryTag> builder)
  {
    builder.HasKey(et => new { et.EntryId, et.TagId });

    builder.HasOne(et => et.Entry)
        .WithMany(e => e.EntryTags)
        .HasForeignKey(et => et.EntryId)
        .OnDelete(DeleteBehavior.Cascade);

    builder.HasOne(et => et.Tag)
        .WithMany(t => t.EntryTags)
        .HasForeignKey(et => et.TagId)
        .OnDelete(DeleteBehavior.Cascade);
  }
}
