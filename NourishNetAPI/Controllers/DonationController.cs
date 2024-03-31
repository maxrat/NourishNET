using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NourishNet.Domain.Entities;
using NourishNet.Repository.Data;
using NourishNetAPI.DTO.Donation;

namespace NourishNetAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class DonationController : ControllerBase
{
    private readonly NourishNetDbContext _context;

    public DonationController(NourishNetDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateDonation([FromBody] CreateDonationDTO donationDTO)
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DonationDetailDTO>> GetDonation(int id)
    {
        return Ok();
    }

    [HttpGet("{cityId}")]
    public async Task<ActionResult<IList<DonationDetailDTO>>> GetDonationsByCityId(int cityId)
    {
        return Ok();
    }

}
