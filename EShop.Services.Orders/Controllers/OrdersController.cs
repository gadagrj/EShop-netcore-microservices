using System.Threading.Tasks;
using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using EShop.Services.Orders.Commands;
using EShop.Services.Orders.DTO;
using EShop.Services.Orders.Queries;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Services.Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public OrdersController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<OrderDto>> Get([FromRoute] GetOrder query)
        {
            var order = await _queryDispatcher.QueryAsync(query);
            if (order is null)
            {
                return NotFound();
            }

            return order;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateOrder command)
        {
            await _commandDispatcher.SendAsync(command);
            return CreatedAtAction(nameof(Get), new {orderId = command.OrderId}, new object());
        }
    }
}
