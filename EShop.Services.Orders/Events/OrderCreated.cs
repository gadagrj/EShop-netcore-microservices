using System;
using Convey.CQRS.Events;

namespace EShop.Services.Orders.Events
{
    public class OrderCreated : IEvent
    {
        public Guid OrderId { get; }

        public OrderCreated(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
