using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NourishNet.Domain.Entities;
using NourishNet.Repository.Data;
using NourishNetAPI.DTO.Product;


[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly NourishNetDbContext _context;

    public ProductController(NourishNetDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult<IList<ProductDTO>>> GetAllAsync()
    {
        return Ok();
    }

}
