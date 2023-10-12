using Microsoft.AspNetCore.Mvc;
using Domain;
using Domain.Interfaces;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ReferralsController : ControllerBase
{
    private readonly ILogger<ReferralsController> _logger;
    private readonly IReferralsRepository _repo;

    public ReferralsController(ILogger<ReferralsController> logger, IReferralsRepository repo)
    {
        _logger = logger;
        _repo = repo;
    }

    [HttpPost("Update")]
    public async Task<IActionResult> Update([FromForm]Referral referral)
    {
        var result = _repo.Update(referral);

        if (string.IsNullOrEmpty(result)) return BadRequest();

        return Ok(result);
    }
}