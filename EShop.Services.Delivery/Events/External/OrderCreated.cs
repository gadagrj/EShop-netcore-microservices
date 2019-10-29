using System;
using Convey.CQRS.Events;
using Convey.MessageBrokers;

namespace EShop.Services.Deliveries.Events.External
{
    [Message("orders")]
    public class OrderCreated : IEvent
    {
        public Guid OrderId { get; }

        public OrderCreated(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
