using System;
using System.Threading.Tasks;
using Convey.CQRS.Queries;
using Convey.Persistence.MongoDB;
using EShop.Services.Orders.Domain;
using EShop.Services.Orders.DTO;

namespace EShop.Services.Orders.Queries.Handlers
{
    public class GetOrderHandler : IQueryHandler<GetOrder, OrderDto>
    {
        private readonly IMongoRepository<Order, Guid> _repository;

        public GetOrderHandler(IMongoRepository<Order, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<OrderDto> HandleAsync(GetOrder query)
        {
            var order = await _repository.GetAsync(query.OrderId);

            return order is null
                ? null
                : new OrderDto {Id = order.Id, CustomerId = order.CustomerId, TotalAmount = order.TotalAmount};
        }
    }
}
