using Convey;
using EShop.Services.Orders.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EShop.Services.Orders
{
    public static class Extensions
    {
        public static IConveyBuilder AddServices(this IConveyBuilder builder)
        {
            builder.Services.AddSingleton<IPricingServiceClient, PricingServiceClient>();
            return builder;
        }
    }
}
