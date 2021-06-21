using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalisSoft.Octopus.Domain.Entities;

namespace TalisSoft.Octopus.Persistence.Configurations
{
  public class PackConfiguration: IEntityTypeConfiguration<Pack>
  {
    public void Configure(EntityTypeBuilder<Pack> builder)
    {
      builder
        .Property(p => p.Description)
        .IsRequired()
        .HasMaxLength(150);
      
      builder
        .Property(p => p.Dimension)
        .HasColumnType("jsonb");
    }
  }
}