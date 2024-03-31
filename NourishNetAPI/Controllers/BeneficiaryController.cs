using NourishNet.Domain.Entities;
using NourishNet.Repository.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NourishNetAPI.DTO.Beneficiary;

namespace NourishNetAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BeneficiaryController : ControllerBase
{
    private readonly NourishNetDbContext _context;

    public BeneficiaryController(NourishNetDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IList<BeneficiaryDTO>>> GetAllAsync()
    {        
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<BeneficiaryDTO>> GetAsync(int? id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult<BeneficiaryDetailDTO>> CreateAsync(CreateBeneficiaryDTO createBeneficiaryDTO)
    {
       return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> EditAsync(int id, EditBeneficiaryDTO editBeneficiaryDTO)
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        return Ok();
    }
}
