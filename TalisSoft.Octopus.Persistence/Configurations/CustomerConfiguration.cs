using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalisSoft.Octopus.Domain.Entities;

namespace TalisSoft.Octopus.Persistence.Configurations
{
    public class CustomerConfiguration: IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
              .Property(c => c.Email)
              .IsRequired()
              .HasMaxLength(50);
            
            builder
              .Property(c => c.FirstName)
              .IsRequired()
              .HasMaxLength(75);
            
            builder
              .Property(c => c.LastName)
              .IsRequired()
              .HasMaxLength(50);
            
            builder
              .Property(c => c.Addresses)
              .HasColumnType("jsonb");

            builder.Property(c => c.CustomerNo)
              .HasDefaultValueSql("nextval('\"CustomerNumbers\"')");
            
            builder.Property(c => c.FullName)
              .HasComputedColumnSql(@"""FirstName"" || ' ' || ""LastName""", stored: true);
        }
    }
}