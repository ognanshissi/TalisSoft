using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TalisSoft.Common.Domain.Entities;
using TalisSoft.Octopus.Domain.Entities;

namespace TalisSoft.Octopus.Persistence
{
    public class OctopusDbContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Path> Paths { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public OctopusDbContext(DbContextOptions<OctopusDbContext> options): base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OctopusDbContext).Assembly);
        }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<Auditable>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = DateTime.UtcNow;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}