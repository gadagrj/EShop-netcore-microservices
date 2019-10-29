using System;

namespace EShop.Services.Pricing.DTO
{
    public class PricingDto
    {
        public Guid OrderId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
