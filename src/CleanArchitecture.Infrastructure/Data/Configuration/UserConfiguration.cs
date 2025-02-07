namespace CleanArchitecture.Infrastructure.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
  public void Configure(EntityTypeBuilder<User> builder)
  {
    builder.HasMany(u => u.Entries)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Cascade);

    builder.Property(u => u.FirstName)
        .HasMaxLength(100);

    builder.Property(u => u.LastName)
        .HasMaxLength(100);

    builder.Property(u => u.RefreshToken)
        .HasMaxLength(500);

    builder.Property(u => u.RefreshTokenExpiration)
        .HasColumnType("timestamp without time zone");
  }
}
