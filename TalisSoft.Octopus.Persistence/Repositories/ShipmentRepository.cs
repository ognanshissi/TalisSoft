using TalisSoft.Common.Persistence.Repositories;
using TalisSoft.Octopus.Application.Contracts.Persistence;
using TalisSoft.Octopus.Domain.Entities;

namespace TalisSoft.Octopus.Persistence.Repositories
{
    public class ShipmentRepository: BaseRepository<Shipment, OctopusDbContext>, IShipmentRepository
    {
        public ShipmentRepository(OctopusDbContext context) : base(context)
        {
        }
    }
}