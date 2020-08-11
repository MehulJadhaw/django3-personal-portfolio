using System.Threading.Tasks;
using InfoApp.API.Dtos;
using InfoApp.API.Models;

namespace InfoApp.API.Data
{
    public interface IAuthRepository
    {
        Task<Shipment> ShipmentDetails(Shipment shipment); 
    }
}