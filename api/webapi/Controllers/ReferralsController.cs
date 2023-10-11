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

    // get all referrals associated with patient based on: firstname lastname dob
    [HttpGet("Get")]
    public async Task<List<Referral>> Get(string firstName, string lastName, DateTime dob)
    {
        return _repo.Get(firstName, lastName, dob);
    }

    [HttpPost("Update")]
    public async Task<IActionResult> Update(Referral referral)
    {
        if (_repo.Update(referral) > 0)
            return Ok();
        else
            return BadRequest();
    }
}