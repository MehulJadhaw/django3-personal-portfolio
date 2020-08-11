using System.Threading.Tasks;
using InfoApp.API.Dtos;
using InfoApp.API.Models;

namespace InfoApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;

        }
        public  async Task<Shipment> ShipmentDetails(Shipment shipment)
        {
            await _context.Shipments.AddAsync(shipment);
            await _context.SaveChangesAsync();

            return shipment;
        }
    }
}