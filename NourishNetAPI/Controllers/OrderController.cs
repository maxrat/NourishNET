using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NourishNet.Domain.Entities;
using NourishNet.Repository.Data;
using NourishNetAPI.DTO.Order;
using OrderStatusEnum = NourishNet.Domain.Enums.OrderStatus;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly NourishNetDbContext _context;

    public OrderController(NourishNetDbContext context)
    {
        _context = context;
    }

    // POST: api/Order
    [HttpPost]
    public async Task<ActionResult<OrderDTO>> CreateOrder()
    {
        return Ok();
    }

    // GET: api/Order/5
    [HttpGet("{id}")]
    public async Task<ActionResult<OrderDTO>> GetOrder(int id)
    {
        return Ok();
    }

    [HttpPatch("{orderId:int}/status")] 
    public async Task<IActionResult> UpdateOrderStatus(int orderId, [FromBody] UpdateOrderStatusDTO updateStatusDTO)
    {
        return Ok();
    }
}
