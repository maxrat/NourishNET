using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NourishNet.Domain.Entities;
using NourishNet.Repository.Data;
using NourishNetAPI.DTO.Beneficiary;
using NourishNetAPI.DTO.Order;
using OrderStatusEnum = NourishNet.Domain.Enums.OrderStatus;

[Route("api/[controller]")]
[ApiController]
public class CourierController : ControllerBase
{

    public CourierController()
    {
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [HttpGet]
    public async Task<ActionResult<IList<CourierDTO>>> GetAllAsync()
    {       
        return Ok();
    }

}
