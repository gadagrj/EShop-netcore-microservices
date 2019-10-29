using System;
using Convey.CQRS.Queries;
using EShop.Services.Orders.DTO;

namespace EShop.Services.Orders.Queries
{
    public class GetOrder : IQuery<OrderDto>
    {
        public Guid OrderId { get; set; }
    }
}
