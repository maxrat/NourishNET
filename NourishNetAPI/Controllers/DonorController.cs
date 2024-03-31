using NourishNet.Domain.Entities;
using NourishNet.Repository.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NourishNetAPI.DTO.Donor;
using NourishNetAPI.DTO.Donation; // Ensure you have the corresponding DTO namespace

namespace NourishNetAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class DonorController : ControllerBase
{
    private readonly NourishNetDbContext _context;

    public DonorController(NourishNetDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IList<DonorDTO>>> GetAllAsync()
    {
        return Ok();
    }

    [HttpGet("{id}")] // Note the use of a route parameter for specifying the donor ID
    public async Task<ActionResult<DonorDTO>> GetAsync(int id) // Removed nullable int since ID is essential
    {
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult<DonorDetailDTO>> CreateAsync()
    {
        return Ok();
    }

    [HttpPut("{id}")] 
    public async Task<IActionResult> EditAsync()
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync()
    {
        return Ok();
    }
}
