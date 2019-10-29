using System;
using System.Threading.Tasks;
using EShop.Services.Orders.DTO;

namespace EShop.Services.Orders.Services
{
    public interface IPricingServiceClient
    {
        Task<PricingDto> GetAsync(Guid orderId);
    }
}
