using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalisSoft.Octopus.Domain.Entities;

namespace TalisSoft.Octopus.Persistence.Configurations
{
  public class PathConfiguration: IEntityTypeConfiguration<Path>
  {
    public void Configure(EntityTypeBuilder<Path> builder)
    {
      builder.Property(p => p.Destination).HasColumnType("jsonb");
      builder.Property(p => p.Source).HasColumnType("jsonb");
    }
  }
}